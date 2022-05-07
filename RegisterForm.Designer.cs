namespace ChatterinoApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.txtParola2 = new System.Windows.Forms.TextBox();
            this.lblConfirmParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.eroareReg = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroareReg)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.Controls.Add(this.btnInregistrare);
            this.MainPanel.Controls.Add(this.txtParola2);
            this.MainPanel.Controls.Add(this.lblConfirmParola);
            this.MainPanel.Controls.Add(this.txtParola);
            this.MainPanel.Controls.Add(this.lblParola);
            this.MainPanel.Controls.Add(this.txtEmail);
            this.MainPanel.Controls.Add(this.lblEmail);
            this.MainPanel.Controls.Add(this.lblUsername);
            this.MainPanel.Controls.Add(this.txtUsername);
            this.MainPanel.Controls.Add(this.panelIcon);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(678, 499);
            this.MainPanel.TabIndex = 0;
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btnInregistrare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInregistrare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnInregistrare.FlatAppearance.BorderSize = 0;
            this.btnInregistrare.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrare.ForeColor = System.Drawing.Color.Black;
            this.btnInregistrare.Image = ((System.Drawing.Image)(resources.GetObject("btnInregistrare.Image")));
            this.btnInregistrare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInregistrare.Location = new System.Drawing.Point(227, 442);
            this.btnInregistrare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(218, 46);
            this.btnInregistrare.TabIndex = 12;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // txtParola2
            // 
            this.txtParola2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola2.Location = new System.Drawing.Point(163, 385);
            this.txtParola2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParola2.Name = "txtParola2";
            this.txtParola2.PasswordChar = '*';
            this.txtParola2.Size = new System.Drawing.Size(346, 32);
            this.txtParola2.TabIndex = 11;
            this.txtParola2.TabStop = false;
            // 
            // lblConfirmParola
            // 
            this.lblConfirmParola.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmParola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmParola.Image = ((System.Drawing.Image)(resources.GetObject("lblConfirmParola.Image")));
            this.lblConfirmParola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConfirmParola.Location = new System.Drawing.Point(163, 351);
            this.lblConfirmParola.Name = "lblConfirmParola";
            this.lblConfirmParola.Size = new System.Drawing.Size(249, 32);
            this.lblConfirmParola.TabIndex = 10;
            this.lblConfirmParola.Text = "Confirmati parola: ";
            this.lblConfirmParola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(163, 308);
            this.txtParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(346, 32);
            this.txtParola.TabIndex = 9;
            this.txtParola.TabStop = false;
            // 
            // lblParola
            // 
            this.lblParola.BackColor = System.Drawing.Color.Transparent;
            this.lblParola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Image = ((System.Drawing.Image)(resources.GetObject("lblParola.Image")));
            this.lblParola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblParola.Location = new System.Drawing.Point(163, 273);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(148, 32);
            this.lblParola.TabIndex = 8;
            this.lblParola.Text = "Parola: ";
            this.lblParola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(163, 234);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(346, 32);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Image = ((System.Drawing.Image)(resources.GetObject("lblEmail.Image")));
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Location = new System.Drawing.Point(163, 199);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(139, 32);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email: ";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Image = ((System.Drawing.Image)(resources.GetObject("lblUsername.Image")));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(159, 119);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(196, 32);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username: ";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(163, 153);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(346, 32);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TabStop = false;
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
            this.panelIcon.Size = new System.Drawing.Size(678, 100);
            this.panelIcon.TabIndex = 2;
            // 
            // eroareReg
            // 
            this.eroareReg.ContainerControl = this;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 499);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatterino! - Inregistrare";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroareReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtParola2;
        private System.Windows.Forms.Label lblConfirmParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.ErrorProvider eroareReg;
    }
}