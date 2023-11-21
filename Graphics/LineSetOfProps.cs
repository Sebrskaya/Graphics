using System.Drawing;
using System.Reflection;

namespace Graphics
{
    class LineSetOfProps : SetOfProperties
    {
        Color LineColor { get; set; }//автоматическое сво-во

        float LineWidth{ get; set; }

        public override void Apply(Painter painter)
        {
            painter.LineWidth = LineWidth;
            painter.LineColor = LineColor;
        }
        public LineSetOfProps(Color color, float width)
        {
            LineColor = color;
            LineWidth = width;
        }
    }
}