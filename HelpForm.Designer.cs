namespace ChatterinoApp
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.panelIcon = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panelIntrebariText = new System.Windows.Forms.Panel();
            this.linkDespre = new System.Windows.Forms.LinkLabel();
            this.lblChat = new System.Windows.Forms.Label();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.btnIntrebare = new System.Windows.Forms.Button();
            this.panelSettingsText = new System.Windows.Forms.Panel();
            this.lblSetariCont = new System.Windows.Forms.Label();
            this.lblSetari = new System.Windows.Forms.Label();
            this.imgChatPanel = new System.Windows.Forms.Panel();
            this.imgAboutPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.panelIntrebariText.SuspendLayout();
            this.panelSettingsText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcon.BackgroundImage")));
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(800, 100);
            this.panelIcon.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.Controls.Add(this.panelIntrebariText);
            this.MainPanel.Controls.Add(this.panelSettingsText);
            this.MainPanel.Controls.Add(this.imgChatPanel);
            this.MainPanel.Controls.Add(this.imgAboutPanel);
            this.MainPanel.Controls.Add(this.panelIcon);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 422);
            this.MainPanel.TabIndex = 1;
            // 
            // panelIntrebariText
            // 
            this.panelIntrebariText.BackColor = System.Drawing.Color.Transparent;
            this.panelIntrebariText.Controls.Add(this.linkDespre);
            this.panelIntrebariText.Controls.Add(this.lblChat);
            this.panelIntrebariText.Controls.Add(this.lblIntrebare);
            this.panelIntrebariText.Controls.Add(this.btnIntrebare);
            this.panelIntrebariText.Location = new System.Drawing.Point(408, 161);
            this.panelIntrebariText.Name = "panelIntrebariText";
            this.panelIntrebariText.Size = new System.Drawing.Size(380, 216);
            this.panelIntrebariText.TabIndex = 9;
            // 
            // linkDespre
            // 
            this.linkDespre.AutoSize = true;
            this.linkDespre.BackColor = System.Drawing.Color.Transparent;
            this.linkDespre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDespre.Location = new System.Drawing.Point(303, 90);
            this.linkDespre.Name = "linkDespre";
            this.linkDespre.Size = new System.Drawing.Size(43, 23);
            this.linkDespre.TabIndex = 9;
            this.linkDespre.TabStop = true;
            this.linkDespre.Text = "aici";
            this.linkDespre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDespre_LinkClicked);
            // 
            // lblChat
            // 
            this.lblChat.BackColor = System.Drawing.Color.Transparent;
            this.lblChat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblChat.Location = new System.Drawing.Point(7, 59);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(365, 62);
            this.lblChat.TabIndex = 10;
            this.lblChat.Text = "Puteti afla mai multe detalii despre acest program apasand  \r\n";
            this.lblChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.BackColor = System.Drawing.Color.Transparent;
            this.lblIntrebare.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntrebare.Location = new System.Drawing.Point(3, 1);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(374, 34);
            this.lblIntrebare.TabIndex = 8;
            this.lblIntrebare.Text = "Intrebari/Feedback";
            this.lblIntrebare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIntrebare
            // 
            this.btnIntrebare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btnIntrebare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIntrebare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIntrebare.FlatAppearance.BorderSize = 0;
            this.btnIntrebare.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntrebare.ForeColor = System.Drawing.Color.Black;
            this.btnIntrebare.Image = ((System.Drawing.Image)(resources.GetObject("btnIntrebare.Image")));
            this.btnIntrebare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntrebare.Location = new System.Drawing.Point(86, 149);
            this.btnIntrebare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIntrebare.Name = "btnIntrebare";
            this.btnIntrebare.Size = new System.Drawing.Size(224, 46);
            this.btnIntrebare.TabIndex = 11;
            this.btnIntrebare.Text = "Pune o intrebare";
            this.btnIntrebare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIntrebare.UseVisualStyleBackColor = false;
            this.btnIntrebare.Click += new System.EventHandler(this.btnIntrebare_Click);
            // 
            // panelSettingsText
            // 
            this.panelSettingsText.BackColor = System.Drawing.Color.Transparent;
            this.panelSettingsText.Controls.Add(this.lblSetariCont);
            this.panelSettingsText.Controls.Add(this.lblSetari);
            this.panelSettingsText.Location = new System.Drawing.Point(13, 161);
            this.panelSettingsText.Name = "panelSettingsText";
            this.panelSettingsText.Size = new System.Drawing.Size(389, 216);
            this.panelSettingsText.TabIndex = 8;
            // 
            // lblSetariCont
            // 
            this.lblSetariCont.BackColor = System.Drawing.Color.Transparent;
            this.lblSetariCont.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetariCont.Location = new System.Drawing.Point(3, 1);
            this.lblSetariCont.Name = "lblSetariCont";
            this.lblSetariCont.Size = new System.Drawing.Size(383, 34);
            this.lblSetariCont.TabIndex = 8;
            this.lblSetariCont.Text = "Setari cont";
            this.lblSetariCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetari
            // 
            this.lblSetari.BackColor = System.Drawing.Color.Transparent;
            this.lblSetari.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetari.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSetari.Location = new System.Drawing.Point(5, 35);
            this.lblSetari.Name = "lblSetari";
            this.lblSetari.Size = new System.Drawing.Size(379, 176);
            this.lblSetari.TabIndex = 7;
            this.lblSetari.Text = "Pentru a te inregistra, ai nevoie de un username, o parola stiuta doar de tine si" +
    " o adresa de email valida.\r\n\r\nCu acest cont te vei loga in aplicatie pentru a pu" +
    "tea folosi Chat-ul.";
            this.lblSetari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgChatPanel
            // 
            this.imgChatPanel.BackColor = System.Drawing.Color.Transparent;
            this.imgChatPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgChatPanel.BackgroundImage")));
            this.imgChatPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgChatPanel.Location = new System.Drawing.Point(408, 106);
            this.imgChatPanel.Name = "imgChatPanel";
            this.imgChatPanel.Size = new System.Drawing.Size(380, 63);
            this.imgChatPanel.TabIndex = 4;
            // 
            // imgAboutPanel
            // 
            this.imgAboutPanel.BackColor = System.Drawing.Color.Transparent;
            this.imgAboutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgAboutPanel.BackgroundImage")));
            this.imgAboutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgAboutPanel.Location = new System.Drawing.Point(12, 106);
            this.imgAboutPanel.Name = "imgAboutPanel";
            this.imgAboutPanel.Size = new System.Drawing.Size(390, 63);
            this.imgAboutPanel.TabIndex = 3;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatterino! - Help";
            this.MainPanel.ResumeLayout(false);
            this.panelIntrebariText.ResumeLayout(false);
            this.panelIntrebariText.PerformLayout();
            this.panelSettingsText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel imgChatPanel;
        private System.Windows.Forms.Panel imgAboutPanel;
        private System.Windows.Forms.Label lblSetari;
        private System.Windows.Forms.Panel panelSettingsText;
        private System.Windows.Forms.Label lblSetariCont;
        private System.Windows.Forms.Panel panelIntrebariText;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.LinkLabel linkDespre;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Button btnIntrebare;
    }
}