namespace NBA
{
    partial class Team
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxSearchTeam = new System.Windows.Forms.ComboBox();
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.dgvStadium = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStadName = new System.Windows.Forms.Label();
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.lbStadCity = new System.Windows.Forms.Label();
            this.lblStadCap = new System.Windows.Forms.Label();
            this.lbCap = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pictBoxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1044, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.playerToolStripMenuItem,
            this.toolStripSeparator1,
            this.mainMenuToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.teamToolStripMenuItem.Text = "Team";
            this.teamToolStripMenuItem.Click += new System.EventHandler(this.teamToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cBoxSearchTeam
            // 
            this.cBoxSearchTeam.FormattingEnabled = true;
            this.cBoxSearchTeam.Location = new System.Drawing.Point(18, 37);
            this.cBoxSearchTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxSearchTeam.Name = "cBoxSearchTeam";
            this.cBoxSearchTeam.Size = new System.Drawing.Size(404, 24);
            this.cBoxSearchTeam.TabIndex = 3;
            // 
            // dgvTeam
            // 
            this.dgvTeam.AllowUserToAddRows = false;
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Location = new System.Drawing.Point(18, 75);
            this.dgvTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.RowHeadersWidth = 51;
            this.dgvTeam.RowTemplate.Height = 24;
            this.dgvTeam.Size = new System.Drawing.Size(811, 267);
            this.dgvTeam.TabIndex = 5;
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamname.Location = new System.Drawing.Point(675, 346);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(85, 24);
            this.lbl_teamname.TabIndex = 10;
            this.lbl_teamname.Text = "...............";
            this.lbl_teamname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_teamname.Visible = false;
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadium.Location = new System.Drawing.Point(48, 370);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(101, 29);
            this.lblStadium.TabIndex = 11;
            this.lblStadium.Text = "Stadium";
            // 
            // dgvStadium
            // 
            this.dgvStadium.AllowUserToAddRows = false;
            this.dgvStadium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStadium.Location = new System.Drawing.Point(18, 420);
            this.dgvStadium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStadium.Name = "dgvStadium";
            this.dgvStadium.RowHeadersWidth = 62;
            this.dgvStadium.RowTemplate.Height = 28;
            this.dgvStadium.Size = new System.Drawing.Size(555, 138);
            this.dgvStadium.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(445, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 32);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStadName
            // 
            this.lblStadName.AutoSize = true;
            this.lblStadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadName.Location = new System.Drawing.Point(722, 436);
            this.lblStadName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStadName.Name = "lblStadName";
            this.lblStadName.Size = new System.Drawing.Size(64, 25);
            this.lblStadName.TabIndex = 14;
            this.lblStadName.Text = "label1";
            this.lblStadName.Visible = false;
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.AllowUserToAddRows = false;
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Location = new System.Drawing.Point(18, 75);
            this.dgvPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.RowHeadersWidth = 62;
            this.dgvPlayer.Size = new System.Drawing.Size(537, 482);
            this.dgvPlayer.TabIndex = 15;
            this.dgvPlayer.Visible = false;
            // 
            // lbStadCity
            // 
            this.lbStadCity.AutoSize = true;
            this.lbStadCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStadCity.Location = new System.Drawing.Point(722, 470);
            this.lbStadCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStadCity.Name = "lbStadCity";
            this.lbStadCity.Size = new System.Drawing.Size(64, 25);
            this.lbStadCity.TabIndex = 16;
            this.lbStadCity.Text = "label2";
            this.lbStadCity.Visible = false;
            // 
            // lblStadCap
            // 
            this.lblStadCap.AutoSize = true;
            this.lblStadCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadCap.Location = new System.Drawing.Point(722, 498);
            this.lblStadCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStadCap.Name = "lblStadCap";
            this.lblStadCap.Size = new System.Drawing.Size(64, 25);
            this.lblStadCap.TabIndex = 17;
            this.lblStadCap.Text = "label3";
            this.lblStadCap.Visible = false;
            // 
            // lbCap
            // 
            this.lbCap.AutoSize = true;
            this.lbCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCap.Location = new System.Drawing.Point(604, 498);
            this.lbCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCap.Name = "lbCap";
            this.lbCap.Size = new System.Drawing.Size(89, 25);
            this.lbCap.TabIndex = 20;
            this.lbCap.Text = "Capacity";
            this.lbCap.Visible = false;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(604, 470);
            this.lbCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(46, 25);
            this.lbCity.TabIndex = 19;
            this.lbCity.Text = "City";
            this.lbCity.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(604, 436);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 25);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Name";
            this.lbName.Visible = false;
            // 
            // pictBoxLogo
            // 
            this.pictBoxLogo.Location = new System.Drawing.Point(636, 75);
            this.pictBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictBoxLogo.Name = "pictBoxLogo";
            this.pictBoxLogo.Size = new System.Drawing.Size(267, 246);
            this.pictBoxLogo.TabIndex = 4;
            this.pictBoxLogo.TabStop = false;
            this.pictBoxLogo.Visible = false;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1044, 571);
            this.Controls.Add(this.lbCap);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lblStadCap);
            this.Controls.Add(this.lbStadCity);
            this.Controls.Add(this.dgvPlayer);
            this.Controls.Add(this.dgvTeam);
            this.Controls.Add(this.lblStadName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvStadium);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.pictBoxLogo);
            this.Controls.Add(this.cBoxSearchTeam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Team";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Team_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBoxSearchTeam;
        private System.Windows.Forms.PictureBox pictBoxLogo;
        private System.Windows.Forms.DataGridView dgvTeam;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStadium;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStadName;
        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.Label lbStadCity;
        private System.Windows.Forms.Label lblStadCap;
        private System.Windows.Forms.Label lbCap;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
    }
}