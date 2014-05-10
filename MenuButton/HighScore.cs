using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuButton
{
   
    public partial class HighScore : Form
    {
        Rankings f1;
        private Font font;
        private Font titleFont;
        private int points;
        public HighScore(Font font,Font titleFont,int points)
        {
            InitializeComponent();
            f1 = new Rankings(font);
            this.font = font;
            this.titleFont = titleFont;
            this.points = points;
        }

        public void setFont(Font setFont)
        {
        foreach (Control control in this.Controls)
            {
                control.Font = setFont;
            }
        label1.Font = titleFont;
        }
        
        

        

        private void btn_SaveScore_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                String[] splitted = tb_EnterName.Text.Split();
                String nameAndScore = String.Format("{0} {1}", splitted[0],points); // 3 treba da se smeni so score od druga forma
                Rankings.newScore(nameAndScore);
                // vrati vo main menu
                this.Hide();
                DialogResult dr = f1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            
        }

       

        

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_EnterName_Validating(object sender, CancelEventArgs e)
        {
            if (tb_EnterName.Text.Trim() == "")
            {
                e.Cancel = true;
                this.errorProvider1.SetError(tb_EnterName, "You must enter a name");
            }
            else
            {
                e.Cancel = false;
                this.errorProvider1.SetError(tb_EnterName, null);
            }
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            setFont(font);
        }


        

      

        

    }
}
