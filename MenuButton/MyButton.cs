using MenuButton.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuButton
{
    class MyButton : Button
    {

        public static Font _normalFont;
        public static Font _hoverFont;



    private static Color _back = System.Drawing.Color.Black;
    private static Color _border = System.Drawing.Color.Transparent;
    private static Color _activeBorder = System.Drawing.Color.Red;
    private static Color _fore = System.Drawing.Color.Black;


   

    public MyButton()
        : base()
    {
        base.Font = _normalFont;
        base.BackColor = _border;
        base.ForeColor = _fore;
        //base.FlatAppearance.BorderColor = _border;
        base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        base.FlatAppearance.MouseOverBackColor = _border;
        base.FlatAppearance.MouseDownBackColor = _border;


        int width = Resources.ButtonIcon.Width;
        int height = Resources.ButtonIcon.Height;

        base.Image = ResizeBitmap(Resources.ButtonIcon, width*2,height*2 );
        

        base.ImageAlign = ContentAlignment.MiddleLeft;
        base.TextAlign = ContentAlignment.MiddleCenter;

        base.FlatAppearance.BorderSize = 0;
    }

    private static Bitmap ResizeBitmap(Bitmap sourceBMP, int width, int height)
    {
        Bitmap result = new Bitmap(width, height);
        using (Graphics g = Graphics.FromImage(result))
            g.DrawImage(sourceBMP, 0, 0, width, height);
        return result;
    }


    public void SetFont(Font font)
    {
        base.Font = font;
        
    }
   


    protected override void OnControlAdded(ControlEventArgs e)
    {
        base.OnControlAdded(e);
        UseVisualStyleBackColor = false;
    }

    protected override void OnMouseEnter(System.EventArgs e)
    {
        base.OnMouseEnter(e);
        base.Font = _hoverFont;

        base.Focus();

        base.ForeColor = Color.Red;
    }

    protected override void OnMouseLeave(System.EventArgs e)
    {
        
        base.OnMouseLeave(e);
        base.Font = _normalFont;
        base.ForeColor = Color.Black;
    }

    protected override void OnGotFocus(EventArgs e)
    {
        base.OnGotFocus(e);

        base.Font = _hoverFont;
        base.ForeColor = Color.Red;
    }
    protected override void OnLostFocus(EventArgs e)
    {
        base.OnLostFocus(e);

        base.Font = _normalFont;
        base.ForeColor = Color.Black;
    }


    }
}
