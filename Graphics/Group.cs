namespace Graphics
{
    internal class Group(List<GrObject>) : base()
    {
        override Draw (Painter p)
        {
            for(int i = 0; i < list.Count; i++)
            {
                list[i].Draw(p);
            }
        } 
    }
}