namespace Graphics.FigureItems
{
    class Line : Figure
    {
        public Line(Frame frame, Properties properties) : base(frame, properties) { }
        public override void DrawGeometry(Painter painter)
        {
            painter.Line(Frame.X1, Frame.Y1, Frame.X2, Frame.Y2);
        }
    }
}