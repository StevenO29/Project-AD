namespace NBA
{
    partial class Boxscore
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
            this.dataDetail = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblReferee = new System.Windows.Forms.Label();
            this.lblRefereeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetail)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDetail
            // 
            this.dataDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetail.Location = new System.Drawing.Point(31, 90);
            this.dataDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataDetail.Name = "dataDetail";
            this.dataDetail.ReadOnly = true;
            this.dataDetail.RowHeadersWidth = 51;
            this.dataDetail.RowTemplate.Height = 24;
            this.dataDetail.Size = new System.Drawing.Size(977, 470);
            this.dataDetail.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1040, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblReferee
            // 
            this.lblReferee.AutoSize = true;
            this.lblReferee.Location = new System.Drawing.Point(27, 46);
            this.lblReferee.Name = "lblReferee";
            this.lblReferee.Size = new System.Drawing.Size(71, 17);
            this.lblReferee.TabIndex = 2;
            this.lblReferee.Text = "Referee : ";
            // 
            // lblRefereeName
            // 
            this.lblRefereeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRefereeName.AutoSize = true;
            this.lblRefereeName.Location = new System.Drawing.Point(103, 46);
            this.lblRefereeName.Name = "lblRefereeName";
            this.lblRefereeName.Size = new System.Drawing.Size(20, 17);
            this.lblRefereeName.TabIndex = 3;
            this.lblRefereeName.Text = "...";
            // 
            // Boxscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBA.Properties.Resources.Untitled_design__2_;
            this.ClientSize = new System.Drawing.Size(1040, 571);
            this.Controls.Add(this.lblRefereeName);
            this.Controls.Add(this.lblReferee);
            this.Controls.Add(this.dataDetail);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Boxscore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box Score";
            this.Load += new System.EventHandler(this.Boxscore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDetail)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDetail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblReferee;
        private System.Windows.Forms.Label lblRefereeName;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}