namespace NBA
{
    partial class Game
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
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_home = new System.Windows.Forms.Label();
            this.lbl_away = new System.Windows.Forms.Label();
            this.pbox_home = new System.Windows.Forms.PictureBox();
            this.pbox_away = new System.Windows.Forms.PictureBox();
            this.lbl_teamhome = new System.Windows.Forms.Label();
            this.lbl_teamaway = new System.Windows.Forms.Label();
            this.btn_detail = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_away)).BeginInit();
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
            this.teamToolStripMenuItem,
            this.playerToolStripMenuItem,
            this.toolStripSeparator1,
            this.mainMenuToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.teamToolStripMenuItem.Text = "Team";
            this.teamToolStripMenuItem.Click += new System.EventHandler(this.teamToolStripMenuItem_Click);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(367, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Location = new System.Drawing.Point(314, 124);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(45, 17);
            this.lbl_home.TabIndex = 2;
            this.lbl_home.Text = "Home";
            // 
            // lbl_away
            // 
            this.lbl_away.AutoSize = true;
            this.lbl_away.Location = new System.Drawing.Point(629, 124);
            this.lbl_away.Name = "lbl_away";
            this.lbl_away.Size = new System.Drawing.Size(41, 17);
            this.lbl_away.TabIndex = 3;
            this.lbl_away.Text = "Away";
            // 
            // pbox_home
            // 
            this.pbox_home.Location = new System.Drawing.Point(302, 169);
            this.pbox_home.Name = "pbox_home";
            this.pbox_home.Size = new System.Drawing.Size(67, 63);
            this.pbox_home.TabIndex = 4;
            this.pbox_home.TabStop = false;
            // 
            // pbox_away
            // 
            this.pbox_away.Location = new System.Drawing.Point(614, 169);
            this.pbox_away.Name = "pbox_away";
            this.pbox_away.Size = new System.Drawing.Size(67, 63);
            this.pbox_away.TabIndex = 5;
            this.pbox_away.TabStop = false;
            // 
            // lbl_teamhome
            // 
            this.lbl_teamhome.AutoSize = true;
            this.lbl_teamhome.Location = new System.Drawing.Point(319, 254);
            this.lbl_teamhome.Name = "lbl_teamhome";
            this.lbl_teamhome.Size = new System.Drawing.Size(40, 17);
            this.lbl_teamhome.TabIndex = 6;
            this.lbl_teamhome.Text = "........";
            // 
            // lbl_teamaway
            // 
            this.lbl_teamaway.AutoSize = true;
            this.lbl_teamaway.Location = new System.Drawing.Point(629, 254);
            this.lbl_teamaway.Name = "lbl_teamaway";
            this.lbl_teamaway.Size = new System.Drawing.Size(40, 17);
            this.lbl_teamaway.TabIndex = 7;
            this.lbl_teamaway.Text = "........";
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(455, 336);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(75, 23);
            this.btn_detail.TabIndex = 8;
            this.btn_detail.Text = "Detail";
            this.btn_detail.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 571);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.lbl_teamaway);
            this.Controls.Add(this.lbl_teamhome);
            this.Controls.Add(this.pbox_away);
            this.Controls.Add(this.pbox_home);
            this.Controls.Add(this.lbl_away);
            this.Controls.Add(this.lbl_home);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_away)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.Label lbl_away;
        private System.Windows.Forms.PictureBox pbox_home;
        private System.Windows.Forms.PictureBox pbox_away;
        private System.Windows.Forms.Label lbl_teamhome;
        private System.Windows.Forms.Label lbl_teamaway;
        private System.Windows.Forms.Button btn_detail;
    }
}