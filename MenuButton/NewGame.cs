using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuButton
{
    public partial class NewGame : Form
    {
        Graphics g;
        public Grid gr { get; set; }
        public int points;
        private int timer;
        private Font font;
        private Font titleFont;
        public int level { get; set; }
        bool c = true;
        

        public NewGame(Font font,Font titleFont,int timer,int level)
        {
            InitializeComponent();

            lblTime.Font = font;
            lblTimer.Font = font;
            lblPoints.Font = font;
            lblPointsNumber.Font = font;
            lblPointsNumber.Text = "0";
            lblTimer.Text = "";

            
            g = pictureBox1.CreateGraphics();
            gr = new Grid(g,this,font,titleFont);
            DoubleBuffered = true;
            this.font = font;
            this.titleFont = titleFont;
            this.timer = timer;
            this.level = level;
            pictureBox2.Show();

        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            pictureBox2.Hide();
           
            if (c)
            {

                timerLevel.Start();
                c = false;
            }

            if (e.KeyCode == Keys.Up)
            {

                gr.goUp();
                gr.newTriangle();
                gr.paintMatrix();

               // updatePoints();

         



            }
            if (e.KeyCode == Keys.Down)
            {
                gr.goDown();
                gr.newTriangle();
                gr.paintMatrix();
                //updatePoints();


            }
            if (e.KeyCode == Keys.Left)
            {
                gr.goLeft();
                gr.newTriangle();
                gr.paintMatrix();

                //updatePoints();



            }
            if (e.KeyCode == Keys.Right)
            {

                gr.goRight();
                gr.newTriangle();
                gr.paintMatrix();

                //updatePoints();
               
            }






        }

    


        public void paintMatrix()
        {

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; j++)
                {


                    gr.matrix[i, j].Draw(i, j, g);

                }
            }

        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            gr.paintMatrix();
        }

        private void timerLevel_Tick(object sender, EventArgs e)
        {
            int min = timer/60;
            int seconds = timer%60;
            if (timer == 0)
            {
                
                this.Hide();
                HighScore highScore = new HighScore(font, titleFont,points);
                highScore.ShowDialog();
                this.Close();
            }

            lblTimer.Text = min + ":" + seconds;
            timer--;
            
        }
        public void updatePoints()
        {

            lblPointsNumber.Text = points.ToString();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        
    }
}
