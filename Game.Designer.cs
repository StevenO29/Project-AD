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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_home = new System.Windows.Forms.Label();
            this.pbox_home = new System.Windows.Forms.PictureBox();
            this.lbl_teamhome = new System.Windows.Forms.Label();
            this.lbl_teamaway = new System.Windows.Forms.Label();
            this.btn_detail = new System.Windows.Forms.Button();
            this.picBoxAway = new System.Windows.Forms.PictureBox();
            this.lblAway = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAway)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1174, 36);
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(409, 69);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(337, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.Location = new System.Drawing.Point(240, 175);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(139, 52);
            this.lbl_home.TabIndex = 2;
            this.lbl_home.Text = "Home";
            // 
            // pbox_home
            // 
            this.pbox_home.Location = new System.Drawing.Point(219, 270);
            this.pbox_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbox_home.Name = "pbox_home";
            this.pbox_home.Size = new System.Drawing.Size(175, 167);
            this.pbox_home.TabIndex = 4;
            this.pbox_home.TabStop = false;
            // 
            // lbl_teamhome
            // 
            this.lbl_teamhome.AutoSize = true;
            this.lbl_teamhome.Location = new System.Drawing.Point(289, 483);
            this.lbl_teamhome.Name = "lbl_teamhome";
            this.lbl_teamhome.Size = new System.Drawing.Size(41, 20);
            this.lbl_teamhome.TabIndex = 6;
            this.lbl_teamhome.Text = "........";
            // 
            // lbl_teamaway
            // 
            this.lbl_teamaway.AutoSize = true;
            this.lbl_teamaway.Location = new System.Drawing.Point(832, 483);
            this.lbl_teamaway.Name = "lbl_teamaway";
            this.lbl_teamaway.Size = new System.Drawing.Size(41, 20);
            this.lbl_teamaway.TabIndex = 7;
            this.lbl_teamaway.Text = "........";
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(521, 624);
            this.btn_detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(113, 57);
            this.btn_detail.TabIndex = 8;
            this.btn_detail.Text = "Detail";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // picBoxAway
            // 
            this.picBoxAway.Location = new System.Drawing.Point(761, 270);
            this.picBoxAway.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxAway.Name = "picBoxAway";
            this.picBoxAway.Size = new System.Drawing.Size(175, 167);
            this.picBoxAway.TabIndex = 9;
            this.picBoxAway.TabStop = false;
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.Location = new System.Drawing.Point(782, 175);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(129, 52);
            this.lblAway.TabIndex = 10;
            this.lblAway.Text = "Away";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(535, 325);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(80, 52);
            this.lblVS.TabIndex = 11;
            this.lblVS.Text = "VS";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1020, 624);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 57);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(35, 624);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(113, 57);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 714);
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
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAway)).EndInit();
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
    }
}