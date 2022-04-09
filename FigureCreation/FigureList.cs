namespace NM1
{
    class FigureList
    {
        private List<AbstractFigure> FigList = new List<AbstractFigure>();

        public void AddToList(AbstractFigure Figure)
        {
            FigList.Add(Figure);
        }

        public void PrintList(Render Rn)
        {
            for(int i = 0, len = FigList.Count; i < len; i++)
            {
                System.Console.WriteLine(Rn.FrameRendering(FigList[i].IsFigure));
            }
        }
    }
}