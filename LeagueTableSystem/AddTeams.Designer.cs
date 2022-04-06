namespace LeagueTableSystem
{
    partial class AddTeams
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TeamCoach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dummyLabel = new System.Windows.Forms.Label();
            this.TeamOwner = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTeamLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLeagueName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.leagueIcon = new System.Windows.Forms.PictureBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.AddSavebtn = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TeamCode = new System.Windows.Forms.TextBox();
            this.PatientIDlbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamLogo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leagueIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.TeamCoach);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.dummyLabel);
            this.GroupBox1.Controls.Add(this.TeamOwner);
            this.GroupBox1.Controls.Add(this.groupBox2);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.labelLeagueName);
            this.GroupBox1.Controls.Add(this.groupBox3);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.AddSavebtn);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.TeamName);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.TeamCode);
            this.GroupBox1.Controls.Add(this.PatientIDlbl);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(733, 484);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // TeamCoach
            // 
            this.TeamCoach.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamCoach.Location = new System.Drawing.Point(446, 148);
            this.TeamCoach.Name = "TeamCoach";
            this.TeamCoach.Size = new System.Drawing.Size(204, 26);
            this.TeamCoach.TabIndex = 28;
            this.TeamCoach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeamCoach_KeyDown);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 148);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(159, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "Coach:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dummyLabel
            // 
            this.dummyLabel.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dummyLabel.Location = new System.Drawing.Point(27, 219);
            this.dummyLabel.Name = "dummyLabel";
            this.dummyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dummyLabel.Size = new System.Drawing.Size(159, 41);
            this.dummyLabel.TabIndex = 26;
            this.dummyLabel.Text = "League Name";
            this.dummyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dummyLabel.Visible = false;
            // 
            // TeamOwner
            // 
            this.TeamOwner.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOwner.Location = new System.Drawing.Point(446, 192);
            this.TeamOwner.Name = "TeamOwner";
            this.TeamOwner.Size = new System.Drawing.Size(204, 26);
            this.TeamOwner.TabIndex = 25;
            this.TeamOwner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeamOwner_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBoxTeamLogo);
            this.groupBox2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(425, 243);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(207, 174);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxTeamLogo
            // 
            this.pictureBoxTeamLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTeamLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTeamLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTeamLogo.InitialImage = null;
            this.pictureBoxTeamLogo.Location = new System.Drawing.Point(4, 19);
            this.pictureBoxTeamLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxTeamLogo.Name = "pictureBoxTeamLogo";
            this.pictureBoxTeamLogo.Size = new System.Drawing.Size(199, 151);
            this.pictureBoxTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeamLogo.TabIndex = 0;
            this.pictureBoxTeamLogo.TabStop = false;
            this.pictureBoxTeamLogo.Click += new System.EventHandler(this.pictureBoxTeamLogo_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 421);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Team Logo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // labelLeagueName
            // 
            this.labelLeagueName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeagueName.Location = new System.Drawing.Point(23, 27);
            this.labelLeagueName.Name = "labelLeagueName";
            this.labelLeagueName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLeagueName.Size = new System.Drawing.Size(159, 41);
            this.labelLeagueName.TabIndex = 22;
            this.labelLeagueName.Text = "League Name";
            this.labelLeagueName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.leagueIcon);
            this.groupBox3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox3.Location = new System.Drawing.Point(27, 61);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(155, 135);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // leagueIcon
            // 
            this.leagueIcon.BackColor = System.Drawing.Color.Transparent;
            this.leagueIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leagueIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leagueIcon.InitialImage = null;
            this.leagueIcon.Location = new System.Drawing.Point(4, 19);
            this.leagueIcon.Margin = new System.Windows.Forms.Padding(4);
            this.leagueIcon.Name = "leagueIcon";
            this.leagueIcon.Size = new System.Drawing.Size(147, 112);
            this.leagueIcon.TabIndex = 0;
            this.leagueIcon.TabStop = false;
            // 
            // Label6
            // 
            this.Label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label6.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Lime;
            this.Label6.Location = new System.Drawing.Point(3, 16);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(727, 26);
            this.Label6.TabIndex = 20;
            this.Label6.Text = "New Team";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddSavebtn
            // 
            this.AddSavebtn.BackColor = System.Drawing.Color.Transparent;
            this.AddSavebtn.BackgroundImage = global::LeagueTableSystem.Properties.Resources.champ1;
            this.AddSavebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddSavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSavebtn.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSavebtn.ForeColor = System.Drawing.Color.White;
            this.AddSavebtn.Location = new System.Drawing.Point(285, 436);
            this.AddSavebtn.Name = "AddSavebtn";
            this.AddSavebtn.Size = new System.Drawing.Size(100, 42);
            this.AddSavebtn.TabIndex = 17;
            this.AddSavebtn.Text = "Save";
            this.AddSavebtn.UseVisualStyleBackColor = false;
            this.AddSavebtn.Click += new System.EventHandler(this.AddSavebtn_Click);
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(281, 192);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(159, 26);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Owner:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // TeamName
            // 
            this.TeamName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(446, 104);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(204, 26);
            this.TeamName.TabIndex = 6;
            this.TeamName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeamName_KeyDown);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(281, 104);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(159, 26);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Team Name:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamCode
            // 
            this.TeamCode.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamCode.Location = new System.Drawing.Point(510, 61);
            this.TeamCode.MaxLength = 3;
            this.TeamCode.Name = "TeamCode";
            this.TeamCode.Size = new System.Drawing.Size(65, 26);
            this.TeamCode.TabIndex = 2;
            this.TeamCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TeamCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeamCode_KeyDown);
            this.TeamCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeamCode_KeyPress);
            // 
            // PatientIDlbl
            // 
            this.PatientIDlbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDlbl.Location = new System.Drawing.Point(281, 61);
            this.PatientIDlbl.Name = "PatientIDlbl";
            this.PatientIDlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PatientIDlbl.Size = new System.Drawing.Size(159, 26);
            this.PatientIDlbl.TabIndex = 1;
            this.PatientIDlbl.Text = "Team Code:";
            this.PatientIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LeagueTableSystem.Properties.Resources.champ1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 484);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTeams";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddTeams_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamLogo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leagueIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button AddSavebtn;
        internal System.Windows.Forms.TextBox TeamName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TeamCode;
        internal System.Windows.Forms.Label PatientIDlbl;
        internal System.Windows.Forms.Label labelLeagueName;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.PictureBox leagueIcon;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.PictureBox pictureBoxTeamLogo;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox TeamOwner;
        internal System.Windows.Forms.Label dummyLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.TextBox TeamCoach;
        internal System.Windows.Forms.Label label7;
    }
}