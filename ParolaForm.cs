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
    public partial class ParolaForm : Form
    {
        public ParolaForm()
        {
            InitializeComponent();
        }

        private void btnRecuperare_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtEmail.Text))
                MessageBox.Show("Completati toate campurile!", "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                if(ConexiuneBD.cautare(txtUsername.Text.Trim(), txtEmail.Text.Trim())) {
                    TrimitereEmail.trimitereParola(txtEmail.Text.Trim(), txtUsername.Text.Trim(), ConexiuneBD.returneazaParola());
                    MessageBox.Show("Succes!" + Environment.NewLine + "Parola dvs. v-a fost trimisa pe email.", "Chatterino! - Parola recuperata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else 
                    MessageBox.Show("Datele introduse sunt eronate.", "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
