namespace NM1
{
    class FiguresList
    {
        private List<Figure> FigList = new List<Figure>();

        public void AddToList(Figure Figure)
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