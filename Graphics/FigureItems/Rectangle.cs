namespace Graphics.FigureItems
{
    class Rectangl : Figure
    {
        public Rectangl(Frame frame, Properties properties) : base(frame, properties) { }
        public override void DrawGeometry(Painter painter)
        {
            painter.Rectangle(Frame.X1, Frame.Y1, Frame.X2, Frame.Y2);
        }
    }
}