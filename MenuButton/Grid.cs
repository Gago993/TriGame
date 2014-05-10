using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuButton
{
    public class Grid
    {
        public Shape[,] matrix;
        public readonly int LEVELONE_TIME = 200;
        Graphics graphics;
        bool isOver;
        private Graphics g;
        private NewGame newGame;
        private Font font, titleFont;

        public Grid(Graphics g, NewGame newGame, Font font, Font titleFont)
        {
            this.isOver = false;
            this.matrix = new Shape[5, 5];
            Random r = new Random();
            this.newGame = newGame;
            this.font = font;
            this.titleFont = titleFont;

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; j++)
                {

                    matrix[i, j] = new Shape(0);
                }
            }


            this.matrix[r.Next(5), r.Next(5)] = new Shape(r.Next(4) + 1);
            graphics = g;
            paintMatrix();
        }

        public void IsOver()
        {
            this.isOver = true;
        }

        public void goUp()
        {


            for (int z = 0; z < 5; ++z)
            {
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (j < 4)
                        {
                            if (matrix[i, j].Orientation == 0 && matrix[i, j + 1].Orientation != 0)
                            {
                                matrix[i, j] = new Shape(matrix[i, j + 1].Orientation);
                                matrix[i, j + 1] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 1 && matrix[i, j + 1].Orientation == 3)
                            {
                                newGame.points += 2;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(5);
                                matrix[i, j + 1] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 2 && matrix[i, j + 1].Orientation == 4)
                            {
                                newGame.points += 2;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(5);
                                matrix[i, j + 1] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 5 && matrix[i, j + 1].Orientation == 5)
                            {
                                newGame.points += 4;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(6);
                                matrix[i, j + 1] = new Shape(0);
                            }

                        }

                    }
                }

                paintMatrix();

            }
            paintMatrix();
        }

        public void goLeft()
        {
            for (int z = 0; z < 5; ++z)
            {
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i < 4)
                        {
                            if (matrix[i, j].Orientation == 0 && matrix[i + 1, j].Orientation != 0)
                            {
                                matrix[i, j] = new Shape(matrix[i + 1, j].Orientation);
                                matrix[i + 1, j] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 1 && matrix[i + 1, j].Orientation == 3)
                            {
                                newGame.points += 2;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(5);
                                matrix[i + 1, j] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 4 && matrix[i + 1, j].Orientation == 2)
                            {
                                newGame.points += 2;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(5);
                                matrix[i + 1, j] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 5 && matrix[i + 1, j].Orientation == 5)
                            {
                                newGame.points += 4;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(6);
                                matrix[i + 1, j] = new Shape(0);
                            }


                        }
                    }
                }

                paintMatrix();

            }

        }

        public void goRight()
        {
            for (int z = 0; z < 5; ++z)
            {
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i > 0)
                        {
                            if (matrix[i, j].Orientation == 0 && matrix[i - 1, j].Orientation != 0)
                            {
                                matrix[i, j] = new Shape(matrix[i - 1, j].Orientation);
                                matrix[i - 1, j] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 3 && matrix[i - 1, j].Orientation == 1)
                            {
                                newGame.points += 2;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(5);
                                matrix[i - 1, j] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 2 && matrix[i - 1, j].Orientation == 4)
                            {
                                newGame.points += 2;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(5);
                                matrix[i - 1, j] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 5 && matrix[i - 1, j].Orientation == 5)
                            {
                                newGame.points += 4;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(6);
                                matrix[i - 1, j] = new Shape(0);
                            }


                        }
                    }
                }

                paintMatrix();

            }
        }

        public void goDown()
        {
            for (int z = 0; z < 5; ++z)
            {
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j > 0)
                        {
                            if (matrix[i, j].Orientation == 0 && matrix[i, j - 1].Orientation != 0)
                            {
                                
                                matrix[i, j] = new Shape(matrix[i, j - 1].Orientation);
                                matrix[i, j - 1] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 3 && matrix[i, j - 1].Orientation == 1)
                            {
                                newGame.points += 2;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(5);
                                matrix[i, j - 1] = new Shape(0);
                                
                            }

                            if (matrix[i, j].Orientation == 4 && matrix[i, j - 1].Orientation == 2)
                            {
                                newGame.points += 2;
                                newGame.updatePoints();
                                matrix[i, j] = new Shape(5);
                                matrix[i, j - 1] = new Shape(0);
                            }

                            if (matrix[i, j].Orientation == 5 && matrix[i, j - 1].Orientation == 5)
                            {
                                newGame.points += 4;

                                matrix[i, j] = new Shape(6);
                                matrix[i, j - 1] = new Shape(0);
                            }


                        }
                    }
                }

                paintMatrix();

            }
        }


        public void paintMatrix()
        {



            for (int i = 0; i < 5; ++i)
            {

                for (int j = 0; j < 5; j++)
                {
                    // Bitmap buffer = new Bitmap(463, 457); // probaj pusti so bitmapa dzabe e, pak e sporo
                    matrix[i, j].Draw(i, j, graphics);
                    // graphics.DrawImageUnscaled(buffer, 0, 0);

                }
            }


        }


        public void newLevel(int level)
        {
            
            int time = LEVELONE_TIME;
            if (level == 2)
            {
                time = 100;
                
            }
            if (level == 3)
                time = 60;





            NewGame newgameLevel = new NewGame(this.newGame.gr.font, this.newGame.gr.titleFont, time, level);
    

            newgameLevel.ShowDialog();
            this.newGame.Close(); //stavi hide ..check /******************/


        }



        public void newTriangle()
        {
            int count = 0;
            int crveni = 0;
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j].Orientation == 0)
                        count++;

                    if (matrix[i, j].Orientation == 6)
                        crveni++;


                }
            }


            if (checkSQ())
            {

                this.newGame.Hide();

                HighScore highScore = new HighScore(font, titleFont, newGame.points);
                highScore.ShowDialog();

                newGame.Close();
            }


            if (count == 1)
            {
                
                newGame.Hide();
                HighScore highScore = new HighScore(font, titleFont, newGame.points);
                highScore.ShowDialog();
                newGame.Close();
                //MessageBox.Show("GAME OVER !");
            }




            Random r = new Random();
            int next = r.Next(count);
            int x = r.Next(4);
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (matrix[i, j].Orientation == 0)
                    {
                        next--;
                        if (next == 0)
                        {
                            matrix[i, j] = new Shape(x + 1);

                        }
                    }
                }
            }

        }



        public int getPoints()
        {
            int poi = 0;
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j].Orientation == 5)
                        poi += 2;

                    if (matrix[i, j].Orientation == 6)
                        poi += 5;


                }
            }
            return poi;
        }

        public bool checkSQ()
        {
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j < 4 && i < 4)
                    {
                        if (matrix[i, j].Orientation == 6 && matrix[i + 1, j].Orientation == 6 && matrix[i, j + 1].Orientation == 6 && matrix[i + 1, j + 1].Orientation == 6)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }



    }
}
