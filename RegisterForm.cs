using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatterinoApp
{
    public partial class RegisterForm : Form {
        private readonly String email_pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";

        public RegisterForm() {
            InitializeComponent();
        }
        private void btnInregistrare_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtEmail.Text) || 
                String.IsNullOrEmpty(txtParola.Text) || String.IsNullOrEmpty(txtParola2.Text))
                MessageBox.Show("Completati toate campurile!", "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                /* Validari de date si afisari ErrorProvidere corespunzatoare. */
                if (!Regex.Match(txtUsername.Text, "^[a-zA-Z0-9]{3,15}$").Success) {
                    eroareReg.SetError(txtUsername, "Username-ul trebuie sa aiba intre 3 si 15 caractere.");
                    eroareReg.SetError(txtEmail, null);
                    eroareReg.SetError(txtParola, null);
                    eroareReg.SetError(txtParola2, null);
                    txtUsername.Focus();
                }
                else if(!Regex.Match(txtEmail.Text, email_pattern).Success){
                    eroareReg.SetError(txtUsername, null);
                    eroareReg.SetError(txtEmail, "Formatul adresei de email este invalid.");
                    eroareReg.SetError(txtParola, null);
                    eroareReg.SetError(txtParola2, null);
                    txtEmail.Focus();
                }
                else if(!Regex.Match(txtParola.Text, "^[a-zA-Z0-9]*.{6,}$").Success) {
                    eroareReg.SetError(txtUsername, null);
                    eroareReg.SetError(txtEmail, null);
                    eroareReg.SetError(txtParola, "Parola trebuie sa aiba minim 6 caractere, minim o cifra si minim o litera.");
                    eroareReg.SetError(txtParola2, null);
                    txtParola.Focus();
                }
                else if (!Regex.Match(txtParola2.Text, "^[a-zA-Z0-9]*.{6,}$").Success ||
                    !txtParola2.Text.Equals(txtParola.Text))
                {
                    eroareReg.SetError(txtUsername, null);
                    eroareReg.SetError(txtEmail, null);
                    eroareReg.SetError(txtParola, null);
                    eroareReg.SetError(txtParola2, "Parolele nu corespund.");
                    txtParola2.Focus();
                }
                else {
                    eroareReg.SetError(txtUsername, null);
                    eroareReg.SetError(txtEmail, null);
                    eroareReg.SetError(txtParola, null);
                    eroareReg.SetError(txtParola2, null);

                    var parola_criptata = CriptareParola.encryptParola(txtParola.Text.Trim());

                    /* Daca inregistrarea s-a realizat cu succes.. */
                    if (ConexiuneBD.adaugare(txtUsername.Text.Trim(), Convert.ToBase64String(parola_criptata), txtEmail.Text.Trim())) {
                        TrimitereEmail.creareCont(txtEmail.Text.Trim(), txtUsername.Text.Trim());
                        MessageBox.Show("Contul a fost creat cu succes." + Environment.NewLine +
                       "Detaliile contului v-au fost trimise pe email." + Environment.NewLine +
                       "Acum va puteti loga.", "Chatterino! - Cont creat cu succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}