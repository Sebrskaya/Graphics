namespace Graphics
{
    abstract class Figure: GraphObject
    {
        Properties Properties { get; set; }
        public Figure(Frame frame, Properties properties) : base(frame)
        {
            Properties= properties;
        }
        public override void Draw(Painter painter)
        {
            Properties.Apply(painter);
            DrawGeometry(painter);
        }

        public abstract void DrawGeometry(Painter painter);
    }
}