namespace NBA
{
    partial class AddPlayer
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
            this.lblPID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTID = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblUmur = new System.Windows.Forms.Label();
            this.txtBoxPlayerID = new System.Windows.Forms.TextBox();
            this.txtBoxPlayerName = new System.Windows.Forms.TextBox();
            this.txtBoxPOS = new System.Windows.Forms.TextBox();
            this.numUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cBoxTeamID = new System.Windows.Forms.ComboBox();
            this.pBox_logoNBA = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_logoNBA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.Location = new System.Drawing.Point(64, 61);
            this.lblPID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(89, 24);
            this.lblPID.TabIndex = 0;
            this.lblPID.Text = "Player ID ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblTID
            // 
            this.lblTID.AutoSize = true;
            this.lblTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTID.Location = new System.Drawing.Point(64, 120);
            this.lblTID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTID.Name = "lblTID";
            this.lblTID.Size = new System.Drawing.Size(59, 24);
            this.lblTID.TabIndex = 2;
            this.lblTID.Text = "Team";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.Location = new System.Drawing.Point(64, 179);
            this.lblPName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(123, 24);
            this.lblPName.TabIndex = 3;
            this.lblPName.Text = "Player Name ";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(64, 239);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(76, 24);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Position";
            // 
            // lblUmur
            // 
            this.lblUmur.AutoSize = true;
            this.lblUmur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmur.Location = new System.Drawing.Point(64, 294);
            this.lblUmur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUmur.Name = "lblUmur";
            this.lblUmur.Size = new System.Drawing.Size(45, 24);
            this.lblUmur.TabIndex = 5;
            this.lblUmur.Text = "Age";
            // 
            // txtBoxPlayerID
            // 
            this.txtBoxPlayerID.Location = new System.Drawing.Point(238, 64);
            this.txtBoxPlayerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPlayerID.MaxLength = 9;
            this.txtBoxPlayerID.Name = "txtBoxPlayerID";
            this.txtBoxPlayerID.Size = new System.Drawing.Size(189, 20);
            this.txtBoxPlayerID.TabIndex = 6;
            // 
            // txtBoxPlayerName
            // 
            this.txtBoxPlayerName.Location = new System.Drawing.Point(238, 179);
            this.txtBoxPlayerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPlayerName.Name = "txtBoxPlayerName";
            this.txtBoxPlayerName.Size = new System.Drawing.Size(310, 20);
            this.txtBoxPlayerName.TabIndex = 8;
            // 
            // txtBoxPOS
            // 
            this.txtBoxPOS.Location = new System.Drawing.Point(238, 239);
            this.txtBoxPOS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPOS.MaxLength = 3;
            this.txtBoxPOS.Name = "txtBoxPOS";
            this.txtBoxPOS.Size = new System.Drawing.Size(81, 20);
            this.txtBoxPOS.TabIndex = 9;
            // 
            // numUpDownAge
            // 
            this.numUpDownAge.Location = new System.Drawing.Point(238, 297);
            this.numUpDownAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUpDownAge.Name = "numUpDownAge";
            this.numUpDownAge.Size = new System.Drawing.Size(80, 20);
            this.numUpDownAge.TabIndex = 10;
            this.numUpDownAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(565, 394);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Location = new System.Drawing.Point(661, 394);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cBoxTeamID
            // 
            this.cBoxTeamID.FormattingEnabled = true;
            this.cBoxTeamID.Location = new System.Drawing.Point(238, 120);
            this.cBoxTeamID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxTeamID.Name = "cBoxTeamID";
            this.cBoxTeamID.Size = new System.Drawing.Size(189, 21);
            this.cBoxTeamID.TabIndex = 13;
            // 
            // pBox_logoNBA
            // 
            this.pBox_logoNBA.Image = global::NBA.Properties.Resources.NBA_75th_anniversary_logo_removebg_preview__1___2_;
            this.pBox_logoNBA.Location = new System.Drawing.Point(708, 28);
            this.pBox_logoNBA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox_logoNBA.Name = "pBox_logoNBA";
            this.pBox_logoNBA.Size = new System.Drawing.Size(75, 57);
            this.pBox_logoNBA.TabIndex = 18;
            this.pBox_logoNBA.TabStop = false;
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBA.Properties.Resources.bgnba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 464);
            this.Controls.Add(this.pBox_logoNBA);
            this.Controls.Add(this.cBoxTeamID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numUpDownAge);
            this.Controls.Add(this.txtBoxPOS);
            this.Controls.Add(this.txtBoxPlayerName);
            this.Controls.Add(this.txtBoxPlayerID);
            this.Controls.Add(this.lblUmur);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.lblTID);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Player";
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_logoNBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTID;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblUmur;
        private System.Windows.Forms.TextBox txtBoxPlayerID;
        private System.Windows.Forms.TextBox txtBoxPlayerName;
        private System.Windows.Forms.TextBox txtBoxPOS;
        private System.Windows.Forms.NumericUpDown numUpDownAge;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cBoxTeamID;
        private System.Windows.Forms.PictureBox pBox_logoNBA;
    }
}