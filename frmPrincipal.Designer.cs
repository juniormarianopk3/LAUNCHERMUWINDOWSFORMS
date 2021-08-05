namespace LAUNCHERMUWINDOWSFORMS
{
    partial class frmPrincipal
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
            this.BtnJogar = new System.Windows.Forms.Button();
            this.PbArqTotal = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnMinimizer = new System.Windows.Forms.Button();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.CmbResolution = new System.Windows.Forms.ComboBox();
            this.LblResolução = new System.Windows.Forms.Label();
            this.ChkWindowMode = new System.Windows.Forms.CheckBox();
            this.ChkMusic = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.PbArq = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnJogar
            // 
            this.BtnJogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnJogar.Enabled = false;
            this.BtnJogar.FlatAppearance.BorderSize = 0;
            this.BtnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJogar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJogar.Location = new System.Drawing.Point(668, 302);
            this.BtnJogar.Name = "BtnJogar";
            this.BtnJogar.Size = new System.Drawing.Size(125, 28);
            this.BtnJogar.TabIndex = 0;
            this.BtnJogar.Text = "Start";
            this.BtnJogar.UseCompatibleTextRendering = true;
            this.BtnJogar.UseVisualStyleBackColor = false;
            this.BtnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // PbArqTotal
            // 
            this.PbArqTotal.Location = new System.Drawing.Point(66, 317);
            this.PbArqTotal.Name = "PbArqTotal";
            this.PbArqTotal.Size = new System.Drawing.Size(432, 10);
            this.PbArqTotal.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(761, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.Gold;
            this.lblUpdate.Location = new System.Drawing.Point(226, 282);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(36, 17);
            this.lblUpdate.TabIndex = 5;
            this.lblUpdate.Text = "label1";
            this.lblUpdate.UseCompatibleTextRendering = true;
            // 
            // btnMinimizer
            // 
            this.btnMinimizer.BackColor = System.Drawing.Color.Red;
            this.btnMinimizer.FlatAppearance.BorderSize = 0;
            this.btnMinimizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizer.Location = new System.Drawing.Point(723, 15);
            this.btnMinimizer.Name = "btnMinimizer";
            this.btnMinimizer.Size = new System.Drawing.Size(32, 23);
            this.btnMinimizer.TabIndex = 7;
            this.btnMinimizer.Text = "_";
            this.btnMinimizer.UseVisualStyleBackColor = false;
            this.btnMinimizer.Click += new System.EventHandler(this.BtnMinimizer_Click);
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.Gold;
            this.LblLogin.Location = new System.Drawing.Point(45, 28);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(33, 17);
            this.LblLogin.TabIndex = 8;
            this.LblLogin.Text = "Login";
            this.LblLogin.UseCompatibleTextRendering = true;
            // 
            // TxtLogin
            // 
            this.TxtLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogin.Location = new System.Drawing.Point(45, 45);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(98, 20);
            this.TxtLogin.TabIndex = 9;
            // 
            // CmbResolution
            // 
            this.CmbResolution.AutoCompleteCustomSource.AddRange(new string[] {
            "Resolution 1",
            "Resolution 2",
            "Resolution 3",
            "Resolution 4"});
            this.CmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbResolution.Location = new System.Drawing.Point(149, 45);
            this.CmbResolution.Name = "CmbResolution";
            this.CmbResolution.Size = new System.Drawing.Size(90, 21);
            this.CmbResolution.TabIndex = 10;
            // 
            // LblResolução
            // 
            this.LblResolução.AutoSize = true;
            this.LblResolução.BackColor = System.Drawing.Color.Transparent;
            this.LblResolução.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResolução.ForeColor = System.Drawing.Color.Gold;
            this.LblResolução.Location = new System.Drawing.Point(149, 28);
            this.LblResolução.Name = "LblResolução";
            this.LblResolução.Size = new System.Drawing.Size(60, 17);
            this.LblResolução.TabIndex = 11;
            this.LblResolução.Text = "Resolução";
            this.LblResolução.UseCompatibleTextRendering = true;
            // 
            // ChkWindowMode
            // 
            this.ChkWindowMode.AutoSize = true;
            this.ChkWindowMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkWindowMode.ForeColor = System.Drawing.Color.Gold;
            this.ChkWindowMode.Location = new System.Drawing.Point(45, 75);
            this.ChkWindowMode.Name = "ChkWindowMode";
            this.ChkWindowMode.Size = new System.Drawing.Size(98, 17);
            this.ChkWindowMode.TabIndex = 12;
            this.ChkWindowMode.Text = "Modo Janela";
            this.ChkWindowMode.UseVisualStyleBackColor = true;
            // 
            // ChkMusic
            // 
            this.ChkMusic.AutoSize = true;
            this.ChkMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMusic.ForeColor = System.Drawing.Color.Gold;
            this.ChkMusic.Location = new System.Drawing.Point(149, 75);
            this.ChkMusic.Name = "ChkMusic";
            this.ChkMusic.Size = new System.Drawing.Size(66, 17);
            this.ChkMusic.TabIndex = 13;
            this.ChkMusic.Text = "Música";
            this.ChkMusic.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.CmbResolution);
            this.groupBox1.Controls.Add(this.ChkMusic);
            this.groupBox1.Controls.Add(this.LblLogin);
            this.groupBox1.Controls.Add(this.ChkWindowMode);
            this.groupBox1.Controls.Add(this.TxtLogin);
            this.groupBox1.Controls.Add(this.LblResolução);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(526, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // PbArq
            // 
            this.PbArq.Location = new System.Drawing.Point(66, 302);
            this.PbArq.Name = "PbArq";
            this.PbArq.Size = new System.Drawing.Size(432, 10);
            this.PbArq.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbArq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMinimizer);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.PbArqTotal);
            this.Controls.Add(this.BtnJogar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher MuOnline";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnJogar;
        private System.Windows.Forms.ProgressBar PbArqTotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnMinimizer;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblResolução;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker Worker;
        public System.Windows.Forms.TextBox TxtLogin;
        public System.Windows.Forms.ComboBox CmbResolution;
        public System.Windows.Forms.CheckBox ChkWindowMode;
        public System.Windows.Forms.CheckBox ChkMusic;
        private System.Windows.Forms.ProgressBar PbArq;
        private System.Windows.Forms.Label label1;
    }
}

