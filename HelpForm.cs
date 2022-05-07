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
    public partial class HelpForm : Form {
        public HelpForm() {
            InitializeComponent();
        }

        private void linkDespre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void btnIntrebare_Click(object sender, EventArgs e) {
            this.Hide();
            QuestionForm question = new QuestionForm();
            question.ShowDialog();
            this.Show();
        }
    }
}