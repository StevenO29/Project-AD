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
            this.playerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxSearchTeam = new System.Windows.Forms.ComboBox();
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.pictBoxLogo = new System.Windows.Forms.PictureBox();
            this.dgvStadium = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadium)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 33);
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // playerToolStripMenuItem1
            // 
            this.playerToolStripMenuItem1.Name = "playerToolStripMenuItem1";
            this.playerToolStripMenuItem1.Size = new System.Drawing.Size(161, 34);
            this.playerToolStripMenuItem1.Text = "Player";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cBoxSearchTeam
            // 
            this.cBoxSearchTeam.FormattingEnabled = true;
            this.cBoxSearchTeam.Location = new System.Drawing.Point(14, 53);
            this.cBoxSearchTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxSearchTeam.Name = "cBoxSearchTeam";
            this.cBoxSearchTeam.Size = new System.Drawing.Size(454, 28);
            this.cBoxSearchTeam.TabIndex = 3;
            // 
            // dgvTeam
            // 
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Location = new System.Drawing.Point(14, 102);
            this.dgvTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.RowHeadersWidth = 51;
            this.dgvTeam.RowTemplate.Height = 24;
            this.dgvTeam.Size = new System.Drawing.Size(601, 582);
            this.dgvTeam.TabIndex = 5;
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamname.Location = new System.Drawing.Point(830, 286);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(102, 26);
            this.lbl_teamname.TabIndex = 10;
            this.lbl_teamname.Text = "...............";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadium.Location = new System.Drawing.Point(838, 398);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(119, 32);
            this.lblStadium.TabIndex = 11;
            this.lblStadium.Text = "Stadium";
            // 
            // pictBoxLogo
            // 
            this.pictBoxLogo.Location = new System.Drawing.Point(797, 46);
            this.pictBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictBoxLogo.Name = "pictBoxLogo";
            this.pictBoxLogo.Size = new System.Drawing.Size(216, 202);
            this.pictBoxLogo.TabIndex = 4;
            this.pictBoxLogo.TabStop = false;
            // 
            // dgvStadium
            // 
            this.dgvStadium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStadium.Location = new System.Drawing.Point(639, 457);
            this.dgvStadium.Name = "dgvStadium";
            this.dgvStadium.RowHeadersWidth = 62;
            this.dgvStadium.RowTemplate.Height = 28;
            this.dgvStadium.Size = new System.Drawing.Size(514, 227);
            this.dgvStadium.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(492, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 40);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 714);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvStadium);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.dgvTeam);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadium)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem1;
        private System.Windows.Forms.Button btnSearch;
    }
}