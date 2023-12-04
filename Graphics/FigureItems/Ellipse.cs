namespace Graphics.FigureItems
{
    class Ellipse : Figure
    {
        public Ellipse(Frame frame, Properties properties) : base(frame, properties) { }
        public override void DrawGeometry(Painter painter)
        {
            painter.Ellipse(Frame.X1, Frame.Y1,  Frame.X2, Frame.Y2);
        }
    }
}