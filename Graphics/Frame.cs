namespace Graphics
{
    class Frame
    {
        float x1, y1, x2, y2;
        public Frame(float x1, float y1, float x2, float y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public float X1 { get { return x1; } }
        public float Y1 { get { return y1; } }
        public float X2 { get { return x2; } }
        public float Y2 { get { return y2; } }

        
        public static Frame operator + (Frame left, Frame right) 
        {
            float x1, x2, y1, y2;
            if (left.x1 >= right.x1)
                x1 = right.x1;
            else
                x1 = left.x1;
            if (left.y1 >= right.y1)
                y1 = right.y1;
            else
                y1 = left.y1;
            if (left.x2 <= right.x2)
                x2 = right.x2;
            else
                x2 = left.x2;
            if (left.y2 <= right.y2)
                y2 = right.y2;
            else
                y2 = left.y2;

            return new Frame(x1, y1, x2, y2);
        }
    }
}