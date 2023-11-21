namespace Graphics
{
     class Properties: List<SetOfProperties>
    {
        
        public void Apply(Painter painter)
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i].Apply(painter);
            }
        }
    }
}