using System.Drawing;
using System.Reflection;

namespace Graphics.SetOfPropsItems
{
    class FillSetOfProps : SetOfProperties
    {
        Color FillColor { get; set; }

        public override void Apply(Painter painter)
        {
            painter.FillColor = FillColor;
        }
        public FillSetOfProps(Color fillColor)
        {
            FillColor = fillColor;
        }
    }
}