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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateGame = new System.Windows.Forms.DateTimePicker();
            this.lbl_home = new System.Windows.Forms.Label();
            this.lbl_teamhome = new System.Windows.Forms.Label();
            this.lbl_teamaway = new System.Windows.Forms.Label();
            this.btn_detail = new System.Windows.Forms.Button();
            this.lblAway = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picBoxAway = new System.Windows.Forms.PictureBox();
            this.pbox_home = new System.Windows.Forms.PictureBox();
            this.lbStad = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
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
            this.teamToolStripMenuItem,
            this.playerToolStripMenuItem,
            this.toolStripSeparator1,
            this.mainMenuToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.teamToolStripMenuItem.Text = "Team";
            this.teamToolStripMenuItem.Click += new System.EventHandler(this.teamToolStripMenuItem_Click);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dateGame
            // 
            this.dateGame.CustomFormat = "yyyy-MM-dd";
            this.dateGame.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGame.Location = new System.Drawing.Point(410, 69);
            this.dateGame.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateGame.Name = "dateGame";
            this.dateGame.Size = new System.Drawing.Size(337, 26);
            this.dateGame.TabIndex = 1;
            this.dateGame.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.Location = new System.Drawing.Point(174, 137);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(139, 52);
            this.lbl_home.TabIndex = 2;
            this.lbl_home.Text = "Home";
            // 
            // lbl_teamhome
            // 
            this.lbl_teamhome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_teamhome.AutoSize = true;
            this.lbl_teamhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamhome.Location = new System.Drawing.Point(117, 545);
            this.lbl_teamhome.Name = "lbl_teamhome";
            this.lbl_teamhome.Size = new System.Drawing.Size(89, 37);
            this.lbl_teamhome.TabIndex = 6;
            this.lbl_teamhome.Text = "........";
            this.lbl_teamhome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_teamaway
            // 
            this.lbl_teamaway.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_teamaway.AutoEllipsis = true;
            this.lbl_teamaway.AutoSize = true;
            this.lbl_teamaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamaway.Location = new System.Drawing.Point(821, 545);
            this.lbl_teamaway.Name = "lbl_teamaway";
            this.lbl_teamaway.Size = new System.Drawing.Size(89, 37);
            this.lbl_teamaway.TabIndex = 7;
            this.lbl_teamaway.Text = "........";
            this.lbl_teamaway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(520, 625);
            this.btn_detail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(112, 57);
            this.btn_detail.TabIndex = 8;
            this.btn_detail.Text = "Detail";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.Location = new System.Drawing.Point(849, 137);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(129, 52);
            this.lblAway.TabIndex = 10;
            this.lblAway.Text = "Away";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(526, 246);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(80, 52);
            this.lblVS.TabIndex = 11;
            this.lblVS.Text = "VS";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1020, 625);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 57);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(34, 625);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(112, 57);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(777, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picBoxAway
            // 
            this.picBoxAway.Location = new System.Drawing.Point(828, 232);
            this.picBoxAway.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picBoxAway.Name = "picBoxAway";
            this.picBoxAway.Size = new System.Drawing.Size(225, 231);
            this.picBoxAway.TabIndex = 9;
            this.picBoxAway.TabStop = false;
            // 
            // pbox_home
            // 
            this.pbox_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbox_home.InitialImage = null;
            this.pbox_home.Location = new System.Drawing.Point(124, 232);
            this.pbox_home.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbox_home.Name = "pbox_home";
            this.pbox_home.Size = new System.Drawing.Size(225, 231);
            this.pbox_home.TabIndex = 4;
            this.pbox_home.TabStop = false;
            // 
            // lbStad
            // 
            this.lbStad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStad.AutoSize = true;
            this.lbStad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStad.Location = new System.Drawing.Point(473, 434);
            this.lbStad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStad.Name = "lbStad";
            this.lbStad.Size = new System.Drawing.Size(49, 29);
            this.lbStad.TabIndex = 16;
            this.lbStad.Text = "......";
            this.lbStad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 714);
            this.Controls.Add(this.lbStad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblAway);
            this.Controls.Add(this.picBoxAway);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.lbl_teamaway);
            this.Controls.Add(this.lbl_teamhome);
            this.Controls.Add(this.pbox_home);
            this.Controls.Add(this.lbl_home);
            this.Controls.Add(this.dateGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateGame;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.PictureBox pbox_home;
        private System.Windows.Forms.Label lbl_teamhome;
        private System.Windows.Forms.Label lbl_teamaway;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.PictureBox picBoxAway;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbStad;
    }
}