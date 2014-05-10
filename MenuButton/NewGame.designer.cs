namespace MenuButton
{
    partial class NewGame
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
            this.timerLevel = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPointsNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLevel
            // 
            this.timerLevel.Interval = 1000;
            this.timerLevel.Tick += new System.EventHandler(this.timerLevel_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleDescription = "public";
            this.pictureBox2.Image = global::MenuButton.Properties.Resources.ngm1;
            this.pictureBox2.Location = new System.Drawing.Point(26, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(523, 130);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MenuButton.Properties.Resources.Background;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblPoints);
            this.panel1.Controls.Add(this.lblPointsNumber);
            this.panel1.Location = new System.Drawing.Point(460, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 457);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::MenuButton.Properties.Resources.back;
            this.panel2.Location = new System.Drawing.Point(3, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 54);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Location = new System.Drawing.Point(10, 83);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(26, 13);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "time";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(11, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(10, 154);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(53, 20);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "Points";
            // 
            // lblPointsNumber
            // 
            this.lblPointsNumber.AutoSize = true;
            this.lblPointsNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPointsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsNumber.Location = new System.Drawing.Point(9, 210);
            this.lblPointsNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointsNumber.Name = "lblPointsNumber";
            this.lblPointsNumber.Size = new System.Drawing.Size(18, 20);
            this.lblPointsNumber.TabIndex = 3;
            this.lblPointsNumber.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MenuButton.Properties.Resources._460x446back;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 457);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 457);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewGame";
            this.Text = "Tri Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerLevel;
        private System.Windows.Forms.Label lblPointsNumber;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;

    }
}

