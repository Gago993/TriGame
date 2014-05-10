namespace MenuButton
{
    partial class HighScore
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
            this.btn_SaveScore = new System.Windows.Forms.Button();
            this.tb_EnterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SaveScore
            // 
            this.btn_SaveScore.Location = new System.Drawing.Point(89, 364);
            this.btn_SaveScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SaveScore.Name = "btn_SaveScore";
            this.btn_SaveScore.Size = new System.Drawing.Size(205, 79);
            this.btn_SaveScore.TabIndex = 1;
            this.btn_SaveScore.Text = "Save";
            this.btn_SaveScore.UseVisualStyleBackColor = true;
            this.btn_SaveScore.Click += new System.EventHandler(this.btn_SaveScore_Click);
            // 
            // tb_EnterName
            // 
            this.tb_EnterName.Location = new System.Drawing.Point(161, 280);
            this.tb_EnterName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EnterName.Name = "tb_EnterName";
            this.tb_EnterName.Size = new System.Drawing.Size(269, 22);
            this.tb_EnterName.TabIndex = 0;
            this.tb_EnterName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_EnterName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Game Over :(";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(158, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.CausesValidation = false;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(332, 364);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(191, 79);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Your Score";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::MenuButton.Properties.Resources.Background;
            this.CancelButton = this.btn_Cancel;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(592, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tb_EnterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SaveScore);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HighScore";
            this.Text = "Rankings";
            this.Load += new System.EventHandler(this.HighScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveScore;
        private System.Windows.Forms.TextBox tb_EnterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label3;
    }
}

