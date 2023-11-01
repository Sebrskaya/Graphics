namespace Graphics
{
    internal class Frame
    {
        public void frame(int x1, int x2, int y1, int y2)
        {

        }
        
        public static Frame operator +(Frame left, Frame right) 
        {
            return new Frame { };
        }
    }
}