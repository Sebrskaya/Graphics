

namespace Graphics
{
    using System.Drawing;
    class Painter
    {
        Graphics graphics;
        Pen pen;
        SolidBrush solidBrush;

        public Painter()
        {
            pen = new Pen(Color.Black);
            solidBrush = new SolidBrush(Color.White);
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

        public Color FillColor
        {
            set
            {
                solidBrush.Color = value;
            }
        }

        public void Line(float x1, float y1, float x2, float y2)
        {
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }

        public void Rectangle(float x, float y, float width, float height)
        {
            graphics.DrawRectangle(pen, x, y, width, height);
            graphics.FillRectangle(solidBrush, x + pen.Width/2, y + pen.Width/2, width - pen.Width, height - pen.Width);
        }

        public void Ellipse(float x, float y, float width, float height)
        {
            graphics.DrawEllipse(pen, x, y, width, height);
            graphics.FillEllipse(solidBrush, x + pen.Width / 2, y + pen.Width / 2, width - pen.Width, height - pen.Width);
        }

    }
}