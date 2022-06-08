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
            this.button1 = new System.Windows.Forms.Button();
            this.cBoxSearchTeam = new System.Windows.Forms.ComboBox();
            this.pictBoxLogo = new System.Windows.Forms.PictureBox();
            this.dgv_east = new System.Windows.Forms.DataGridView();
            this.dgv_teamwest = new System.Windows.Forms.DataGridView();
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_game = new System.Windows.Forms.Button();
            this.btn_player = new System.Windows.Forms.Button();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.btn_stadium = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_east)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamwest)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem});
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
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBoxSearchTeam
            // 
            this.cBoxSearchTeam.FormattingEnabled = true;
            this.cBoxSearchTeam.Location = new System.Drawing.Point(31, 52);
            this.cBoxSearchTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxSearchTeam.Name = "cBoxSearchTeam";
            this.cBoxSearchTeam.Size = new System.Drawing.Size(433, 24);
            this.cBoxSearchTeam.TabIndex = 3;
            // 
            // pictBoxLogo
            // 
            this.pictBoxLogo.Location = new System.Drawing.Point(716, 92);
            this.pictBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictBoxLogo.Name = "pictBoxLogo";
            this.pictBoxLogo.Size = new System.Drawing.Size(192, 162);
            this.pictBoxLogo.TabIndex = 4;
            this.pictBoxLogo.TabStop = false;
            // 
            // dgv_east
            // 
            this.dgv_east.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_east.Location = new System.Drawing.Point(31, 92);
            this.dgv_east.Name = "dgv_east";
            this.dgv_east.RowHeadersWidth = 51;
            this.dgv_east.RowTemplate.Height = 24;
            this.dgv_east.Size = new System.Drawing.Size(279, 413);
            this.dgv_east.TabIndex = 5;
            // 
            // dgv_teamwest
            // 
            this.dgv_teamwest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teamwest.Location = new System.Drawing.Point(366, 92);
            this.dgv_teamwest.Name = "dgv_teamwest";
            this.dgv_teamwest.RowHeadersWidth = 51;
            this.dgv_teamwest.RowTemplate.Height = 24;
            this.dgv_teamwest.Size = new System.Drawing.Size(279, 413);
            this.dgv_teamwest.TabIndex = 6;
            // 
            // btn_stats
            // 
            this.btn_stats.Location = new System.Drawing.Point(716, 308);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(192, 23);
            this.btn_stats.TabIndex = 7;
            this.btn_stats.Text = "stats";
            this.btn_stats.UseVisualStyleBackColor = true;
            // 
            // btn_game
            // 
            this.btn_game.Location = new System.Drawing.Point(716, 337);
            this.btn_game.Name = "btn_game";
            this.btn_game.Size = new System.Drawing.Size(192, 23);
            this.btn_game.TabIndex = 8;
            this.btn_game.Text = "game";
            this.btn_game.UseVisualStyleBackColor = true;
            // 
            // btn_player
            // 
            this.btn_player.Location = new System.Drawing.Point(716, 367);
            this.btn_player.Name = "btn_player";
            this.btn_player.Size = new System.Drawing.Size(192, 23);
            this.btn_player.TabIndex = 9;
            this.btn_player.Text = "player";
            this.btn_player.UseVisualStyleBackColor = true;
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Location = new System.Drawing.Point(784, 269);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(46, 17);
            this.lbl_teamname.TabIndex = 10;
            this.lbl_teamname.Text = "label1";
            // 
            // btn_stadium
            // 
            this.btn_stadium.Location = new System.Drawing.Point(716, 396);
            this.btn_stadium.Name = "btn_stadium";
            this.btn_stadium.Size = new System.Drawing.Size(192, 23);
            this.btn_stadium.TabIndex = 11;
            this.btn_stadium.Text = "stadium";
            this.btn_stadium.UseVisualStyleBackColor = true;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 571);
            this.Controls.Add(this.btn_stadium);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.btn_player);
            this.Controls.Add(this.btn_game);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.dgv_teamwest);
            this.Controls.Add(this.dgv_east);
            this.Controls.Add(this.pictBoxLogo);
            this.Controls.Add(this.cBoxSearchTeam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Team";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_east)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamwest)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cBoxSearchTeam;
        private System.Windows.Forms.PictureBox pictBoxLogo;
        private System.Windows.Forms.DataGridView dgv_east;
        private System.Windows.Forms.DataGridView dgv_teamwest;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_game;
        private System.Windows.Forms.Button btn_player;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.Button btn_stadium;
    }
}