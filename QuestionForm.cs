using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatterinoApp
{
    public partial class QuestionForm : Form {
        String email_pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";
        public QuestionForm() {
            InitializeComponent();
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNume.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtMesaj.Text))
            {
                MessageBox.Show("Completati toate campurile!", "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                /* Validare de campuri. */
                if (!Regex.Match(txtNume.Text, "^[a-zA-Z]{3,20}$").Success) {
                    eroareFeedback.SetError(txtNume, "Nume invalid!");
                    txtNume.Focus();
                }
                else if (!Regex.Match(txtEmail.Text, email_pattern).Success) {
                    eroareFeedback.SetError(txtNume, null);
                    eroareFeedback.SetError(txtEmail, "Email invalid!");
                    txtEmail.Focus();
                }
                else {
                    eroareFeedback.SetError(txtEmail, null);
                    TrimitereEmail.trimitereFeedback(txtEmail.Text.Trim(), txtNume.Text.Trim(), txtMesaj.Text.Trim());
                    MessageBox.Show("Mesajul dvs. a fost transmis." + Environment.NewLine +
                      "Multumim.", "Chatterino! - Mesaj transmis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
        }
    }
}