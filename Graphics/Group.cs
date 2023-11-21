namespace Graphics
{
    class Group : GraphObject
    {
        List<GraphObject> list = new List<GraphObject>();
        public Group(List<GraphObject> list) : base(SetFrame(list))
        {
            for(int i = 0; i < list.Count; i++) 
            {
                this.list.Add(list[i]);
            }
        }
        public override void Draw(Painter painter)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Draw(painter);
            }
        }
        private static Frame SetFrame(List<GraphObject> list)
        {
            Frame newFrame = list[0].Frame;
            for(int i = 1; i < list.Count; i++)
            {
                newFrame += list[i].Frame;
            }
            return newFrame;
        }
    }
}