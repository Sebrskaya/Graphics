namespace Graphics
{
    abstract class GraphObject
    {
        Frame frame;
        public GraphObject(Frame frame)
        {
            this.frame = frame;
        }

        public abstract void Draw(Painter painter);

        public Frame Frame 
        {
            get { return frame; }
        }


    }
}