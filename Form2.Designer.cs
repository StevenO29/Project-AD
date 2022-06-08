﻿namespace NBA
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenuPlayer = new System.Windows.Forms.Button();
            this.btnMenuTeam = new System.Windows.Forms.Button();
            this.btnMenuGame = new System.Windows.Forms.Button();
            this.picBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.BackgroundImage = global::NBA.Properties.Resources.Exit__1___2_;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(1047, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenuPlayer
            // 
            this.btnMenuPlayer.BackgroundImage = global::NBA.Properties.Resources._3;
            this.btnMenuPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuPlayer.Location = new System.Drawing.Point(77, 491);
            this.btnMenuPlayer.Name = "btnMenuPlayer";
            this.btnMenuPlayer.Size = new System.Drawing.Size(413, 151);
            this.btnMenuPlayer.TabIndex = 3;
            this.btnMenuPlayer.UseVisualStyleBackColor = true;
            this.btnMenuPlayer.Click += new System.EventHandler(this.btnMenuPlayer_Click);
            // 
            // btnMenuTeam
            // 
            this.btnMenuTeam.BackgroundImage = global::NBA.Properties.Resources._2;
            this.btnMenuTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuTeam.Location = new System.Drawing.Point(77, 276);
            this.btnMenuTeam.Name = "btnMenuTeam";
            this.btnMenuTeam.Size = new System.Drawing.Size(413, 151);
            this.btnMenuTeam.TabIndex = 2;
            this.btnMenuTeam.UseVisualStyleBackColor = true;
            this.btnMenuTeam.Click += new System.EventHandler(this.btnMenuTeam_Click);
            // 
            // btnMenuGame
            // 
            this.btnMenuGame.BackgroundImage = global::NBA.Properties.Resources._1;
            this.btnMenuGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuGame.Location = new System.Drawing.Point(77, 59);
            this.btnMenuGame.Name = "btnMenuGame";
            this.btnMenuGame.Size = new System.Drawing.Size(413, 151);
            this.btnMenuGame.TabIndex = 1;
            this.btnMenuGame.UseVisualStyleBackColor = true;
            this.btnMenuGame.Click += new System.EventHandler(this.btnMenuGame_Click);
            // 
            // picBoxBackground
            // 
            this.picBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBackground.Image")));
            this.picBoxBackground.Location = new System.Drawing.Point(-16, 0);
            this.picBoxBackground.Name = "picBoxBackground";
            this.picBoxBackground.Size = new System.Drawing.Size(1191, 711);
            this.picBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBackground.TabIndex = 0;
            this.picBoxBackground.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 714);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMenuPlayer);
            this.Controls.Add(this.btnMenuTeam);
            this.Controls.Add(this.btnMenuGame);
            this.Controls.Add(this.picBoxBackground);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBackground;
        private System.Windows.Forms.Button btnMenuGame;
        private System.Windows.Forms.Button btnMenuTeam;
        private System.Windows.Forms.Button btnMenuPlayer;
        private System.Windows.Forms.Button btnExit;
    }
}