namespace NBA
{
    partial class LoadingPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingPage));
            this.pictBoxLogo = new System.Windows.Forms.PictureBox();
            this.progBarLoadScreen = new System.Windows.Forms.ProgressBar();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxLogo
            // 
            this.pictBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxLogo.Image")));
            this.pictBoxLogo.Location = new System.Drawing.Point(-6, -2);
            this.pictBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictBoxLogo.Name = "pictBoxLogo";
            this.pictBoxLogo.Size = new System.Drawing.Size(791, 455);
            this.pictBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxLogo.TabIndex = 0;
            this.pictBoxLogo.TabStop = false;
            // 
            // progBarLoadScreen
            // 
            this.progBarLoadScreen.Location = new System.Drawing.Point(0, 452);
            this.progBarLoadScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progBarLoadScreen.MarqueeAnimationSpeed = 30;
            this.progBarLoadScreen.Maximum = 30;
            this.progBarLoadScreen.Name = "progBarLoadScreen";
            this.progBarLoadScreen.Size = new System.Drawing.Size(785, 29);
            this.progBarLoadScreen.TabIndex = 1;
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // LoadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 481);
            this.Controls.Add(this.progBarLoadScreen);
            this.Controls.Add(this.pictBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoadingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA\'s Data";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxLogo;
        private System.Windows.Forms.ProgressBar progBarLoadScreen;
        private System.Windows.Forms.Timer timerLoad;
    }
}

