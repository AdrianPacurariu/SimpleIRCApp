namespace ChatterinoApp
{
    partial class QuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.eroareFeedback = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroareFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.txtMesaj);
            this.MainPanel.Controls.Add(this.lblMesaj);
            this.MainPanel.Controls.Add(this.txtEmail);
            this.MainPanel.Controls.Add(this.lblEmail);
            this.MainPanel.Controls.Add(this.lblNume);
            this.MainPanel.Controls.Add(this.btnTrimite);
            this.MainPanel.Controls.Add(this.txtNume);
            this.MainPanel.Controls.Add(this.panelIcon);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(420, 594);
            this.MainPanel.TabIndex = 1;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesaj.Location = new System.Drawing.Point(18, 318);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(387, 215);
            this.txtMesaj.TabIndex = 11;
            // 
            // lblMesaj
            // 
            this.lblMesaj.BackColor = System.Drawing.Color.Transparent;
            this.lblMesaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(3, 283);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(420, 32);
            this.lblMesaj.TabIndex = 10;
            this.lblMesaj.Text = "Mesajul dvs:";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(28, 240);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 32);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(0, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(420, 32);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Adresa de mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNume
            // 
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(0, 122);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(420, 32);
            this.lblNume.TabIndex = 7;
            this.lblNume.Text = "Nume:";
            this.lblNume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrimite
            // 
            this.btnTrimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btnTrimite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrimite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTrimite.FlatAppearance.BorderSize = 0;
            this.btnTrimite.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimite.ForeColor = System.Drawing.Color.Black;
            this.btnTrimite.Image = ((System.Drawing.Image)(resources.GetObject("btnTrimite.Image")));
            this.btnTrimite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrimite.Location = new System.Drawing.Point(143, 539);
            this.btnTrimite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTrimite.Size = new System.Drawing.Size(141, 46);
            this.btnTrimite.TabIndex = 6;
            this.btnTrimite.Text = "Trimite";
            this.btnTrimite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrimite.UseVisualStyleBackColor = false;
            this.btnTrimite.Click += new System.EventHandler(this.btnTrimite_Click);
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(28, 160);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(360, 32);
            this.txtNume.TabIndex = 3;
            this.txtNume.TabStop = false;
            this.txtNume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcon.BackgroundImage")));
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelIcon.Location = new System.Drawing.Point(0, 2);
            this.panelIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(420, 100);
            this.panelIcon.TabIndex = 1;
            // 
            // eroareFeedback
            // 
            this.eroareFeedback.ContainerControl = this;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 594);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatterino! - Feedback";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroareFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.ErrorProvider eroareFeedback;
    }
}