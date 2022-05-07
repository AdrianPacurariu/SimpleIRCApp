using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatterinoApp
{
    public partial class MainForm : Form {

        private readonly string usernamePlaceholder = "Introduceti username-ul dvs...";
        public MainForm() {
            InitializeComponent();
        }

        private void ScoatePlaceholder(object sender, EventArgs e) {
            txtUsername.ForeColor = Color.Black; 
            if (txtUsername.Text == usernamePlaceholder)
                txtUsername.Text = "";
        }

        public void AdaugaPlaceholder(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) {
                txtUsername.ForeColor = Color.Gray;
                txtUsername.Text = usernamePlaceholder;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            if (int.Parse(DateTime.Now.ToString("HH")) >= 10 && int.Parse(DateTime.Now.ToString("HH")) < 18)
                lblWelcomeMessage.Text = "Buna ziua!";
            else if (int.Parse(DateTime.Now.ToString("HH")) >= 18 && int.Parse(DateTime.Now.ToString("HH")) < 24)
                lblWelcomeMessage.Text = "Buna seara!";
            else if (int.Parse(DateTime.Now.ToString("HH")) >= 24 && int.Parse(DateTime.Now.ToString("HH")) < 10)
                lblWelcomeMessage.Text = "Buna dimineata!";

            txtUsername.ForeColor = Color.Gray;
            txtUsername.Text = usernamePlaceholder; /* Textul initial va fi placeholder-ul. */
            txtUsername.GotFocus += ScoatePlaceholder; /* Daca se face click in caseta, se sterge placeholderul. */
            txtUsername.LostFocus += AdaugaPlaceholder; /* Daca se face click pe o alta componenta, si caseta de username era goala,
                                               * se adauga inapoi placeholderul. */
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) {
            /* Caseta de text pentru parola se va activa doar cand am introdus un username. */
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == usernamePlaceholder) {
                txtPassword.ReadOnly = true;
                txtPassword.Enabled = false;
                txtPassword.Text = "";
            }
            else {
                txtPassword.ReadOnly = false;
                txtPassword.Enabled = true;
            }
        }

        private void helpApp_Click(object sender, EventArgs e) {
            this.Hide();
            HelpForm help = new HelpForm();
            help.ShowDialog();
            this.Show();
        }
        private void btnLogare_Click(object sender, EventArgs e) {
            /* Cu ajutorul ErrorProvider-ului vom face validari. */
            if(string.IsNullOrEmpty(txtUsername.Text) || txtUsername.Text == usernamePlaceholder) {
                errors.SetError(txtUsername, "Introduceti username-ul!");
                errors.SetError(txtPassword, null);
                txtUsername.Focus();
            }
            else if(txtPassword.Text == "") {
                errors.SetError(txtUsername, null);
                errors.SetError(txtPassword, "Introduceti parola!");
                txtPassword.Focus();
            }
            /* Avem si user si parola. */
            else {
                errors.SetError(txtPassword, null);

                /* Se cripteaza parola introdusa. */
                var parola_criptata = CriptareParola.encryptParola(txtPassword.Text.Trim());

                /* Daca parola corespunde cu cea din baza de date, logarea s-a facut cu succes. */
                if (ConexiuneBD.logare(txtUsername.Text.Trim(), Convert.ToBase64String(parola_criptata), errors, txtUsername, txtPassword)) {
                    MessageBox.Show("Logat cu succes!" + Environment.NewLine + "Se va deschide chatul.", "Chatterino! - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ChatForm chat = new ChatForm(txtUsername.Text.Trim());
                    chat.ShowDialog();
                    this.Show();
                }
            }
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
            this.Show();
        }

        private void parolaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ParolaForm recuperare = new ParolaForm();
            recuperare.ShowDialog();
            this.Show();
        }
    }
}