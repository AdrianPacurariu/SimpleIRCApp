using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleIRCLib; /* API-ul serverului IRC. */

namespace ChatterinoApp
{
    public partial class ChatForm : Form {
        private readonly String username;
        private readonly String channel;
        private readonly String IP;
        private readonly int port;
        private readonly SimpleIRC server_irc;

        private readonly string textPlaceholder = "<introduceti mesajul aici>";
        private String getChannel() {
            return channel;
        }

        public ChatForm(String user) {
            /* Aici se pot modifica parametrii cu serverul dvs. */
            /* Tutoriale: 
             * - https://libera.chat/guides/connect
             * - https://libera.chat/guides/registration
             * - https://libera.chat/guides/creatingchannels/ */

            this.username = user;
            this.channel = "<canalul dvs>";
            this.IP = "<ip sau adresa serverului IRC>";
            this.server_irc = new SimpleIRC();
            this.port = 6697; /* De obicei portul implicit este 6697. */

            /* Adaugarea de event handlere pentru receptionarea mesajelor din cliente externe de IRC precum
             * si actualizarea userlist-ului la conectare/deconectare. */
            server_irc.IrcClient.OnMessageReceived += mesajChat;
            server_irc.IrcClient.OnUserListReceived += listaUseri;

            /* Setare si pornire server IRC. */
            server_irc.SetupIrc(IP, username, channel, port);
            server_irc.StartClient();

            InitializeComponent();
        }
        private void ChatForm_Load(object sender, EventArgs e) {
            timerUpdateUsers.Start();
            timerUpdateOra.Start();

            /* Apeluri "false" pentru a porni cu field-urile actualizate. */
            timerUpdateUsers_Tick(null, null);
            timerUpdateOra_Tick(null, null);

            textMesaj.ForeColor = Color.Gray;
            textMesaj.Text = textPlaceholder;
            textMesaj.GotFocus += ScoatePlaceholder;
            textMesaj.LostFocus += AdaugaPlaceholder;

            taskbarIcon.ContextMenuStrip = new ContextMenuStrip();
            taskbarIcon.ContextMenuStrip.Items.Add("Iesire din aplicatie", null, this.btnDeconectare_Click);
        }

        private void ScoatePlaceholder(object sender, EventArgs e)
        {
           textMesaj.ForeColor = Color.Black;
           if (textMesaj.Text == textPlaceholder)
               textMesaj.Text = "";
        }

        public void AdaugaPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textMesaj.Text)) {
                textMesaj.ForeColor = Color.Gray;
                textMesaj.Text = textPlaceholder;
            }
        }
        private void mesajChat(object sender, IrcReceivedEventArgs args) {
            /* User si Message sunt preluate din API. */
            chatHistory.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + args.User + ": " + args.Message + Environment.NewLine);
        }

        private void listaUseri(object sender, IrcUserListReceivedEventArgs args) {
            int k = 0;
            List<string> users_on = new List<string>();
            foreach (KeyValuePair<string, List<string>> utilizatori_conectati in args.UsersPerChannel) {
               foreach (string user in utilizatori_conectati.Value) {
                    users_on.Add(user);
                    k++;
               }
            }

            listaUseriConectati.Clear();

            foreach(string ut in users_on)
                if (!listaUseriConectati.Lines.Distinct().Contains(ut))
                    listaUseriConectati.AppendText(ut + Environment.NewLine);
            lblNumara.Text = k.ToString();
        }
        private void btnTrimiteMesaj_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(textMesaj.Text) && textMesaj.Text != textPlaceholder) {
                server_irc.SendMessageToChannel(textMesaj.Text, getChannel());
                chatHistory.AppendText("[" +DateTime.Now.ToString("HH:mm:ss") + "] " + username + ": " + textMesaj.Text + Environment.NewLine);
                textMesaj.Clear();
                textMesaj.ScrollToCaret();
            }
        }

        private void btnDeconectare_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Veti fi deconectat de pe serverul de chat."
                + Environment.NewLine + "Continuati?", "Chatterino! - Deconectare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (server_irc.IsClientRunning())
                    server_irc.StopClient();
                this.Invoke(new MethodInvoker(() => mesajChat(this, new IrcReceivedEventArgs("disconnected", username, channel))));            
                taskbarIcon.Dispose();
                this.Close();
            }
        }
        private void textMesaj_KeyDown(object sender, KeyEventArgs e) {
            /* La actionarea lui Enter se va trimite mesajul si nu se va insera newline in caseta de text. */
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                btnTrimiteMesaj_Click(this, new EventArgs());
            }
        }

        private void timerUpdateUsers_Tick(object sender, EventArgs e) {
            server_irc.GetUsersInCurrentChannel();
        }

        private void timerUpdateOra_Tick(object sender, EventArgs e) {
            oraSistem.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void taskbarIcon_MouseClick(object sender, MouseEventArgs e) {
            /* Daca se face click stanga pe iconita din Tray, afiseaza un mesaj informativ. */
            if (e.Button == MouseButtons.Left)
                 taskbarIcon.ShowBalloonTip(5000, "Chatterino!", "Chatul este deschis.", ToolTipIcon.Info);
            else if(e.Button == MouseButtons.Right) {
                 taskbarIcon.ContextMenuStrip.Show();
            }
        }
    }
}