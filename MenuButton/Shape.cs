using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuButton
{
    public class Shape
    {

        public int Orientation { set; get; }


        public Shape(int o)
        {
            this.Orientation = o;
        }

        Image triImage;

        public void Draw(int i, int j, Graphics g)
        {
            if (this.Orientation == 1)
                triImage = Properties.Resources.t1;

            if (this.Orientation == 2)
                triImage = Properties.Resources.t2;

            if (this.Orientation == 3)
                triImage = Properties.Resources.t3;

            if (this.Orientation == 4)
                triImage = Properties.Resources.t4;

            if (this.Orientation == 5)
                triImage = Properties.Resources.yellow;

            if (this.Orientation == 6)
                triImage = Properties.Resources.red;

            if (this.Orientation == 0)
                triImage = Properties.Resources.cleared;

            if (triImage != null)
            {
                if (this.Orientation != 0)
                    g.DrawImageUnscaled(Properties.Resources.cleared, new Point(8 + 17 * i + i * triImage.Width, 6 + 17 * j + j * triImage.Height));

                g.DrawImageUnscaled(triImage, new Point(8 + 17 * i + i * triImage.Width, 6 + 17 * j + j * triImage.Height));
            }


        }

        public void Clear(int i, int j, Graphics g, int orientation)
        {

            Image t = Properties.Resources.cleared;
            g.DrawImageUnscaled(t, new Point(8 + 17 * i + i * triImage.Width, 6 + 17 * j + j * triImage.Height));
            this.Orientation = orientation;
        }



    }
}
