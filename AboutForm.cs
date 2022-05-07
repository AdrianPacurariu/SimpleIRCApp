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
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                openGithub();
            }
            catch (Exception ex) {
                MessageBox.Show("Eroare: " + ex.Message, "Chatterino - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openGithub() {
            githubLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/AdrianPacurariu/SimpleIRCApp");
        }
    }
}
