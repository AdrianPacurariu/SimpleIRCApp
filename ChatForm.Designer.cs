namespace ChatterinoApp
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.panelOptiuni = new System.Windows.Forms.Panel();
            this.oraSistem = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.lblUseriConectati = new System.Windows.Forms.Label();
            this.listaUseriConectati = new System.Windows.Forms.TextBox();
            this.btnTrimiteMesaj = new System.Windows.Forms.Button();
            this.chatHistory = new System.Windows.Forms.RichTextBox();
            this.textMesaj = new System.Windows.Forms.RichTextBox();
            this.timerUpdateUsers = new System.Windows.Forms.Timer(this.components);
            this.taskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerUpdateOra = new System.Windows.Forms.Timer(this.components);
            this.panelOptiuni.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOptiuni
            // 
            this.panelOptiuni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOptiuni.BackgroundImage")));
            this.panelOptiuni.Controls.Add(this.oraSistem);
            this.panelOptiuni.Controls.Add(this.lblNumara);
            this.panelOptiuni.Controls.Add(this.btnDeconectare);
            this.panelOptiuni.Controls.Add(this.lblUseriConectati);
            this.panelOptiuni.Controls.Add(this.listaUseriConectati);
            this.panelOptiuni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOptiuni.Location = new System.Drawing.Point(0, 0);
            this.panelOptiuni.Name = "panelOptiuni";
            this.panelOptiuni.Size = new System.Drawing.Size(200, 550);
            this.panelOptiuni.TabIndex = 0;
            // 
            // oraSistem
            // 
            this.oraSistem.BackColor = System.Drawing.Color.Transparent;
            this.oraSistem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oraSistem.Location = new System.Drawing.Point(55, 462);
            this.oraSistem.Name = "oraSistem";
            this.oraSistem.Size = new System.Drawing.Size(93, 26);
            this.oraSistem.TabIndex = 6;
            this.oraSistem.Text = "<ora>";
            this.oraSistem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumara
            // 
            this.lblNumara.BackColor = System.Drawing.Color.Transparent;
            this.lblNumara.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumara.Location = new System.Drawing.Point(167, 14);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(37, 30);
            this.lblNumara.TabIndex = 5;
            this.lblNumara.Text = "0";
            this.lblNumara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeconectare.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDeconectare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconectare.Image = ((System.Drawing.Image)(resources.GetObject("btnDeconectare.Image")));
            this.btnDeconectare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconectare.Location = new System.Drawing.Point(4, 491);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(193, 54);
            this.btnDeconectare.TabIndex = 4;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeconectare.UseVisualStyleBackColor = false;
            this.btnDeconectare.Click += new System.EventHandler(this.btnDeconectare_Click);
            // 
            // lblUseriConectati
            // 
            this.lblUseriConectati.BackColor = System.Drawing.Color.Transparent;
            this.lblUseriConectati.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseriConectati.Location = new System.Drawing.Point(12, 15);
            this.lblUseriConectati.Name = "lblUseriConectati";
            this.lblUseriConectati.Size = new System.Drawing.Size(191, 29);
            this.lblUseriConectati.TabIndex = 1;
            this.lblUseriConectati.Text = "Utilizatori conectati: ";
            this.lblUseriConectati.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listaUseriConectati
            // 
            this.listaUseriConectati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaUseriConectati.BackColor = System.Drawing.SystemColors.Window;
            this.listaUseriConectati.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaUseriConectati.Location = new System.Drawing.Point(3, 55);
            this.listaUseriConectati.Multiline = true;
            this.listaUseriConectati.Name = "listaUseriConectati";
            this.listaUseriConectati.ReadOnly = true;
            this.listaUseriConectati.Size = new System.Drawing.Size(200, 405);
            this.listaUseriConectati.TabIndex = 5;
            // 
            // btnTrimiteMesaj
            // 
            this.btnTrimiteMesaj.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTrimiteMesaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrimiteMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimiteMesaj.Image = ((System.Drawing.Image)(resources.GetObject("btnTrimiteMesaj.Image")));
            this.btnTrimiteMesaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrimiteMesaj.Location = new System.Drawing.Point(824, 491);
            this.btnTrimiteMesaj.Name = "btnTrimiteMesaj";
            this.btnTrimiteMesaj.Size = new System.Drawing.Size(154, 54);
            this.btnTrimiteMesaj.TabIndex = 3;
            this.btnTrimiteMesaj.Text = "Trimite";
            this.btnTrimiteMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrimiteMesaj.UseVisualStyleBackColor = false;
            this.btnTrimiteMesaj.Click += new System.EventHandler(this.btnTrimiteMesaj_Click);
            // 
            // chatHistory
            // 
            this.chatHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatHistory.Location = new System.Drawing.Point(202, 8);
            this.chatHistory.Name = "chatHistory";
            this.chatHistory.Size = new System.Drawing.Size(779, 480);
            this.chatHistory.TabIndex = 5;
            this.chatHistory.Text = "";
            // 
            // textMesaj
            // 
            this.textMesaj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMesaj.Location = new System.Drawing.Point(202, 491);
            this.textMesaj.Name = "textMesaj";
            this.textMesaj.Size = new System.Drawing.Size(616, 54);
            this.textMesaj.TabIndex = 6;
            this.textMesaj.Text = "";
            this.textMesaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMesaj_KeyDown);
            // 
            // timerUpdateUsers
            // 
            this.timerUpdateUsers.Enabled = true;
            this.timerUpdateUsers.Interval = 1000;
            this.timerUpdateUsers.Tick += new System.EventHandler(this.timerUpdateUsers_Tick);
            // 
            // taskbarIcon
            // 
            this.taskbarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskbarIcon.Icon")));
            this.taskbarIcon.Text = "Chatterino!";
            this.taskbarIcon.Visible = true;
            this.taskbarIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.taskbarIcon_MouseClick);
            // 
            // timerUpdateOra
            // 
            this.timerUpdateOra.Enabled = true;
            this.timerUpdateOra.Interval = 1000;
            this.timerUpdateOra.Tick += new System.EventHandler(this.timerUpdateOra_Tick);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 550);
            this.Controls.Add(this.textMesaj);
            this.Controls.Add(this.chatHistory);
            this.Controls.Add(this.btnTrimiteMesaj);
            this.Controls.Add(this.panelOptiuni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatterino!";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.panelOptiuni.ResumeLayout(false);
            this.panelOptiuni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptiuni;
        private System.Windows.Forms.Button btnTrimiteMesaj;
        private System.Windows.Forms.Label lblUseriConectati;
        private System.Windows.Forms.Button btnDeconectare;
        private System.Windows.Forms.TextBox listaUseriConectati;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.RichTextBox chatHistory;
        private System.Windows.Forms.RichTextBox textMesaj;
        private System.Windows.Forms.Timer timerUpdateUsers;
        private System.Windows.Forms.NotifyIcon taskbarIcon;
        private System.Windows.Forms.Label oraSistem;
        private System.Windows.Forms.Timer timerUpdateOra;
    }
}