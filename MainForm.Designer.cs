namespace ChatterinoApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.parolaLink = new System.Windows.Forms.LinkLabel();
            this.btnLogare = new System.Windows.Forms.Button();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.meniuApp = new System.Windows.Forms.MenuStrip();
            this.helpApp = new System.Windows.Forms.ToolStripMenuItem();
            this.errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainPanel.SuspendLayout();
            this.meniuApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errors)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.parolaLink);
            this.MainPanel.Controls.Add(this.btnLogare);
            this.MainPanel.Controls.Add(this.registerLink);
            this.MainPanel.Controls.Add(this.txtPassword);
            this.MainPanel.Controls.Add(this.txtUsername);
            this.MainPanel.Controls.Add(this.lblInfo);
            this.MainPanel.Controls.Add(this.panelIcon);
            this.MainPanel.Controls.Add(this.lblWelcomeMessage);
            this.MainPanel.Controls.Add(this.meniuApp);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(381, 453);
            this.MainPanel.TabIndex = 0;
            // 
            // parolaLink
            // 
            this.parolaLink.BackColor = System.Drawing.Color.Transparent;
            this.parolaLink.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaLink.Location = new System.Drawing.Point(0, 300);
            this.parolaLink.Name = "parolaLink";
            this.parolaLink.Size = new System.Drawing.Size(381, 23);
            this.parolaLink.TabIndex = 7;
            this.parolaLink.TabStop = true;
            this.parolaLink.Text = "Ai uitat parola?";
            this.parolaLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.parolaLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.parolaLink_LinkClicked);
            // 
            // btnLogare
            // 
            this.btnLogare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.btnLogare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLogare.FlatAppearance.BorderSize = 0;
            this.btnLogare.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogare.ForeColor = System.Drawing.Color.Black;
            this.btnLogare.Image = ((System.Drawing.Image)(resources.GetObject("btnLogare.Image")));
            this.btnLogare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogare.Location = new System.Drawing.Point(91, 339);
            this.btnLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(189, 46);
            this.btnLogare.TabIndex = 6;
            this.btnLogare.Text = "Login";
            this.btnLogare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogare.UseVisualStyleBackColor = false;
            this.btnLogare.Click += new System.EventHandler(this.btnLogare_Click);
            // 
            // registerLink
            // 
            this.registerLink.BackColor = System.Drawing.Color.Transparent;
            this.registerLink.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.Location = new System.Drawing.Point(0, 274);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(381, 23);
            this.registerLink.TabIndex = 5;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Nu aveti un cont? Inregistrati-va aici.";
            this.registerLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(18, 238);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(346, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(18, 193);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(346, 32);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TabStop = false;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(0, 144);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(381, 32);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Logati-va pentru a continua.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcon.BackgroundImage")));
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelIcon.Location = new System.Drawing.Point(0, 2);
            this.panelIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(381, 100);
            this.panelIcon.TabIndex = 1;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(0, 106);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(381, 34);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Buna!";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meniuApp
            // 
            this.meniuApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meniuApp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.meniuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpApp});
            this.meniuApp.Location = new System.Drawing.Point(0, 425);
            this.meniuApp.Name = "meniuApp";
            this.meniuApp.Size = new System.Drawing.Size(381, 28);
            this.meniuApp.TabIndex = 0;
            this.meniuApp.Text = "Meniu";
            // 
            // helpApp
            // 
            this.helpApp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpApp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpApp.Image = ((System.Drawing.Image)(resources.GetObject("helpApp.Image")));
            this.helpApp.Name = "helpApp";
            this.helpApp.Size = new System.Drawing.Size(76, 24);
            this.helpApp.Text = "Help";
            this.helpApp.Click += new System.EventHandler(this.helpApp_Click);
            // 
            // errors
            // 
            this.errors.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 453);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.meniuApp;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatterino!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.meniuApp.ResumeLayout(false);
            this.meniuApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.MenuStrip meniuApp;
        private System.Windows.Forms.ToolStripMenuItem helpApp;
        private System.Windows.Forms.ErrorProvider errors;
        private System.Windows.Forms.LinkLabel parolaLink;
    }
}

