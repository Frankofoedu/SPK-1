﻿namespace SPK.UserControls.SubForms
{
    partial class SpecifySubjectNumber
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picSchoolLogo = new System.Windows.Forms.PictureBox();
            this.btnSaveSss = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.btnSaveJss = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.cBoxNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJSSNum = new System.Windows.Forms.Label();
            this.lblSSSnum = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblSSSnum);
            this.panel3.Controls.Add(this.lblJSSNum);
            this.panel3.Controls.Add(this.btnSaveSss);
            this.panel3.Controls.Add(this.btnSaveJss);
            this.panel3.Controls.Add(this.cBoxNum);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(78, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 303);
            this.panel3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(300, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "SELECT NUMBER OF SUBJECT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblSubTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.picSchoolLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 130);
            this.panel1.TabIndex = 21;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Lucida Sans", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(107, 75);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(453, 19);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Specify the number of subject offered by students";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(149, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(352, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SUBJECT MANAGEMENT";
            // 
            // picSchoolLogo
            // 
            this.picSchoolLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.picSchoolLogo.Image = global::SPK.Properties.Resources.icons8_file_64;
            this.picSchoolLogo.Location = new System.Drawing.Point(108, 31);
            this.picSchoolLogo.Name = "picSchoolLogo";
            this.picSchoolLogo.Size = new System.Drawing.Size(40, 40);
            this.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSchoolLogo.TabIndex = 0;
            this.picSchoolLogo.TabStop = false;
            // 
            // btnSaveSss
            // 
            this.btnSaveSss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSaveSss.BtnText = "SAVE FOR SSS";
            this.btnSaveSss.ForeColor = System.Drawing.Color.White;
            this.btnSaveSss.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSaveSss.Icon = global::SPK.Properties.Resources.icons8_save_64;
            this.btnSaveSss.Location = new System.Drawing.Point(560, 103);
            this.btnSaveSss.Name = "btnSaveSss";
            this.btnSaveSss.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSaveSss.Size = new System.Drawing.Size(221, 50);
            this.btnSaveSss.TabIndex = 88;
            // 
            // btnSaveJss
            // 
            this.btnSaveJss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSaveJss.BtnText = "SAVE FOR JSS";
            this.btnSaveJss.ForeColor = System.Drawing.Color.White;
            this.btnSaveJss.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSaveJss.Icon = global::SPK.Properties.Resources.icons8_save_64;
            this.btnSaveJss.Location = new System.Drawing.Point(560, 47);
            this.btnSaveJss.Name = "btnSaveJss";
            this.btnSaveJss.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSaveJss.Size = new System.Drawing.Size(221, 50);
            this.btnSaveJss.TabIndex = 87;
            // 
            // cBoxNum
            // 
            this.cBoxNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxNum.FormattingEnabled = true;
            this.cBoxNum.Items.AddRange(new object[] {
            "--Select--",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cBoxNum.Location = new System.Drawing.Point(359, 85);
            this.cBoxNum.Name = "cBoxNum";
            this.cBoxNum.Size = new System.Drawing.Size(195, 28);
            this.cBoxNum.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(164, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Number of Subjects";
            // 
            // lblJSSNum
            // 
            this.lblJSSNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(216)))));
            this.lblJSSNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(118)))), ((int)(((byte)(61)))));
            this.lblJSSNum.Location = new System.Drawing.Point(168, 164);
            this.lblJSSNum.Name = "lblJSSNum";
            this.lblJSSNum.Size = new System.Drawing.Size(613, 39);
            this.lblJSSNum.TabIndex = 89;
            this.lblJSSNum.Text = "JSS Students must offer 0 subjects";
            this.lblJSSNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSSSnum
            // 
            this.lblSSSnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(216)))));
            this.lblSSSnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(118)))), ((int)(((byte)(61)))));
            this.lblSSSnum.Location = new System.Drawing.Point(166, 219);
            this.lblSSSnum.Name = "lblSSSnum";
            this.lblSSSnum.Size = new System.Drawing.Size(613, 39);
            this.lblSSSnum.TabIndex = 90;
            this.lblSSSnum.Text = "SSS Students must offer 0 subjects";
            this.lblSSSnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpecifySubjectNumber
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "SpecifySubjectNumber";
            this.Size = new System.Drawing.Size(1100, 780);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSchoolLogo;
        private System.Windows.Forms.Label lblSSSnum;
        private System.Windows.Forms.Label lblJSSNum;
        private Buttons.ButtonWithoutMenu btnSaveSss;
        private Buttons.ButtonWithoutMenu btnSaveJss;
        private System.Windows.Forms.ComboBox cBoxNum;
        private System.Windows.Forms.Label label4;
    }
}
