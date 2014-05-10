namespace MenuButton
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbarVolume = new System.Windows.Forms.TrackBar();
            this.lblCurrentSong = new System.Windows.Forms.Label();
            this.btnChooseSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMusicOnOff = new System.Windows.Forms.CheckBox();
            this.openMusicFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_Back_Settings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbHard);
            this.groupBox1.Controls.Add(this.rbMedium);
            this.groupBox1.Controls.Add(this.rbEasy);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(560, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(27, 134);
            this.rbHard.Margin = new System.Windows.Forms.Padding(4);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(60, 21);
            this.rbHard.TabIndex = 2;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(27, 87);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(4);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(78, 21);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(28, 43);
            this.rbEasy.Margin = new System.Windows.Forms.Padding(4);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(60, 21);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbarVolume);
            this.groupBox2.Controls.Add(this.lblCurrentSong);
            this.groupBox2.Controls.Add(this.btnChooseSong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbMusicOnOff);
            this.groupBox2.Location = new System.Drawing.Point(16, 190);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(560, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Music";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Song:";
            // 
            // tbarVolume
            // 
            this.tbarVolume.Location = new System.Drawing.Point(27, 111);
            this.tbarVolume.Margin = new System.Windows.Forms.Padding(4);
            this.tbarVolume.Name = "tbarVolume";
            this.tbarVolume.Size = new System.Drawing.Size(297, 56);
            this.tbarVolume.TabIndex = 5;
            this.tbarVolume.Scroll += new System.EventHandler(this.tbarVolume_Scroll);
            // 
            // lblCurrentSong
            // 
            this.lblCurrentSong.AutoSize = true;
            this.lblCurrentSong.Location = new System.Drawing.Point(349, 150);
            this.lblCurrentSong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentSong.Name = "lblCurrentSong";
            this.lblCurrentSong.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentSong.TabIndex = 4;
            // 
            // btnChooseSong
            // 
            this.btnChooseSong.Location = new System.Drawing.Point(353, 38);
            this.btnChooseSong.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseSong.Name = "btnChooseSong";
            this.btnChooseSong.Size = new System.Drawing.Size(119, 49);
            this.btnChooseSong.TabIndex = 3;
            this.btnChooseSong.Text = "Choose Song";
            this.btnChooseSong.UseVisualStyleBackColor = true;
            this.btnChooseSong.Click += new System.EventHandler(this.btnChooseSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volume";
            // 
            // cbMusicOnOff
            // 
            this.cbMusicOnOff.AutoSize = true;
            this.cbMusicOnOff.Checked = true;
            this.cbMusicOnOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMusicOnOff.Location = new System.Drawing.Point(28, 38);
            this.cbMusicOnOff.Margin = new System.Windows.Forms.Padding(4);
            this.cbMusicOnOff.Name = "cbMusicOnOff";
            this.cbMusicOnOff.Size = new System.Drawing.Size(122, 21);
            this.cbMusicOnOff.TabIndex = 0;
            this.cbMusicOnOff.Text = "Music ON/OFF";
            this.cbMusicOnOff.UseVisualStyleBackColor = true;
            this.cbMusicOnOff.CheckedChanged += new System.EventHandler(this.cbMusicOnOff_CheckedChanged);
            // 
            // openMusicFile
            // 
            this.openMusicFile.FileName = "openMusicFile";
            // 
            // btn_Back_Settings
            // 
            this.btn_Back_Settings.Location = new System.Drawing.Point(44, 418);
            this.btn_Back_Settings.Name = "btn_Back_Settings";
            this.btn_Back_Settings.Size = new System.Drawing.Size(153, 72);
            this.btn_Back_Settings.TabIndex = 13;
            this.btn_Back_Settings.Text = "Back";
            this.btn_Back_Settings.UseVisualStyleBackColor = true;
            this.btn_Back_Settings.Click += new System.EventHandler(this.btn_Back_Settings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::MenuButton.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(592, 502);
            this.Controls.Add(this.btn_Back_Settings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbMusicOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentSong;
        private System.Windows.Forms.Button btnChooseSong;
        private System.Windows.Forms.OpenFileDialog openMusicFile;
        private System.Windows.Forms.TrackBar tbarVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back_Settings;
    }
}

