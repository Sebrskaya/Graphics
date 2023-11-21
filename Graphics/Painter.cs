

namespace Graphics
{
    using System.Drawing;
    class Painter
    {
        Graphics graphics;
        Pen pen;

        public Painter()
        {
            pen = new Pen(Color.Black);
        } 

        public void SetPort(IntPtr handle)//handle -окно для рисования
        {
            graphics = Graphics.FromHwnd(handle);
        }
        public void Clear() 
        {
            graphics.Clear(Color.White);
        }

        public Color LineColor 
        {
            set { pen.Color = value; } 
        }

        public float LineWidth
        {
            set { pen.Width = value;}
        }

        public void Line(float x1, float y1, float x2, float y2)
        {
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }

    }
}