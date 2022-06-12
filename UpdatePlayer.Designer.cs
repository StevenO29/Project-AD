namespace NBA
{
    partial class UpdatePlayer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTeamS = new System.Windows.Forms.ComboBox();
            this.lbTeam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlayerS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDet = new System.Windows.Forms.Button();
            this.lbPlayerID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNameU = new System.Windows.Forms.TextBox();
            this.cbTeamU = new System.Windows.Forms.ComboBox();
            this.cbPosU = new System.Windows.Forms.ComboBox();
            this.lbAva = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.chbAllData = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gbSelect.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // cbTeamS
            // 
            this.cbTeamS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeamS.FormattingEnabled = true;
            this.cbTeamS.Location = new System.Drawing.Point(145, 32);
            this.cbTeamS.Name = "cbTeamS";
            this.cbTeamS.Size = new System.Drawing.Size(378, 33);
            this.cbTeamS.TabIndex = 1;
            this.cbTeamS.SelectedIndexChanged += new System.EventHandler(this.cbTeamS_SelectedIndexChanged);
            // 
            // lbTeam
            // 
            this.lbTeam.AutoSize = true;
            this.lbTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeam.Location = new System.Drawing.Point(40, 35);
            this.lbTeam.Name = "lbTeam";
            this.lbTeam.Size = new System.Drawing.Size(66, 25);
            this.lbTeam.TabIndex = 2;
            this.lbTeam.Text = "Team";
            this.lbTeam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Player";
            // 
            // cbPlayerS
            // 
            this.cbPlayerS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayerS.FormattingEnabled = true;
            this.cbPlayerS.Location = new System.Drawing.Point(145, 89);
            this.cbPlayerS.Name = "cbPlayerS";
            this.cbPlayerS.Size = new System.Drawing.Size(255, 33);
            this.cbPlayerS.TabIndex = 4;
            this.cbPlayerS.SelectedIndexChanged += new System.EventHandler(this.cbPlayerS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.btnDet);
            this.gbSelect.Controls.Add(this.label2);
            this.gbSelect.Controls.Add(this.cbPlayerS);
            this.gbSelect.Controls.Add(this.cbTeamS);
            this.gbSelect.Controls.Add(this.lbTeam);
            this.gbSelect.Location = new System.Drawing.Point(12, 46);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(582, 140);
            this.gbSelect.TabIndex = 7;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.btnDel);
            this.gbUpdate.Controls.Add(this.btnUpdate);
            this.gbUpdate.Controls.Add(this.lbAva);
            this.gbUpdate.Controls.Add(this.cbPosU);
            this.gbUpdate.Controls.Add(this.cbTeamU);
            this.gbUpdate.Controls.Add(this.tbNameU);
            this.gbUpdate.Controls.Add(this.tbID);
            this.gbUpdate.Controls.Add(this.label5);
            this.gbUpdate.Controls.Add(this.lbPlayerID);
            this.gbUpdate.Controls.Add(this.label4);
            this.gbUpdate.Controls.Add(this.label3);
            this.gbUpdate.Location = new System.Drawing.Point(12, 217);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(729, 257);
            this.gbUpdate.TabIndex = 8;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Team";
            // 
            // btnDet
            // 
            this.btnDet.Location = new System.Drawing.Point(448, 96);
            this.btnDet.Name = "btnDet";
            this.btnDet.Size = new System.Drawing.Size(75, 23);
            this.btnDet.TabIndex = 6;
            this.btnDet.Text = "Detail";
            this.btnDet.UseVisualStyleBackColor = true;
            this.btnDet.Click += new System.EventHandler(this.btnDet_Click);
            // 
            // lbPlayerID
            // 
            this.lbPlayerID.AutoSize = true;
            this.lbPlayerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerID.Location = new System.Drawing.Point(72, 40);
            this.lbPlayerID.Name = "lbPlayerID";
            this.lbPlayerID.Size = new System.Drawing.Size(32, 25);
            this.lbPlayerID.TabIndex = 2;
            this.lbPlayerID.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "POS";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(135, 37);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(150, 31);
            this.tbID.TabIndex = 4;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbNameU
            // 
            this.tbNameU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameU.Location = new System.Drawing.Point(135, 72);
            this.tbNameU.Name = "tbNameU";
            this.tbNameU.Size = new System.Drawing.Size(367, 31);
            this.tbNameU.TabIndex = 5;
            // 
            // cbTeamU
            // 
            this.cbTeamU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeamU.FormattingEnabled = true;
            this.cbTeamU.Location = new System.Drawing.Point(135, 107);
            this.cbTeamU.Name = "cbTeamU";
            this.cbTeamU.Size = new System.Drawing.Size(255, 33);
            this.cbTeamU.TabIndex = 7;
            // 
            // cbPosU
            // 
            this.cbPosU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosU.FormattingEnabled = true;
            this.cbPosU.Location = new System.Drawing.Point(135, 142);
            this.cbPosU.Name = "cbPosU";
            this.cbPosU.Size = new System.Drawing.Size(102, 33);
            this.cbPosU.TabIndex = 8;
            // 
            // lbAva
            // 
            this.lbAva.AutoSize = true;
            this.lbAva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAva.Location = new System.Drawing.Point(303, 40);
            this.lbAva.Name = "lbAva";
            this.lbAva.Size = new System.Drawing.Size(48, 25);
            this.lbAva.TabIndex = 9;
            this.lbAva.Text = "......";
            this.lbAva.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(448, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(529, 204);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // chbAllData
            // 
            this.chbAllData.AutoSize = true;
            this.chbAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAllData.Location = new System.Drawing.Point(626, 108);
            this.chbAllData.Name = "chbAllData";
            this.chbAllData.Size = new System.Drawing.Size(106, 29);
            this.chbAllData.TabIndex = 9;
            this.chbAllData.Text = "All Data";
            this.chbAllData.UseVisualStyleBackColor = true;
            this.chbAllData.CheckedChanged += new System.EventHandler(this.chbAllData_CheckedChanged);
            // 
            // UpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 503);
            this.Controls.Add(this.chbAllData);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UpdatePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePlayer";
            this.Load += new System.EventHandler(this.UpdatePlayer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbTeamS;
        private System.Windows.Forms.Label lbTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlayerS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDet;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPlayerID;
        private System.Windows.Forms.Label lbAva;
        private System.Windows.Forms.ComboBox cbPosU;
        private System.Windows.Forms.ComboBox cbTeamU;
        private System.Windows.Forms.TextBox tbNameU;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.CheckBox chbAllData;
    }
}