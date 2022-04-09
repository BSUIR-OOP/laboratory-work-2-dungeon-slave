namespace NM1
{
    class Program
    {
        static void Main()
        {
            FigureList List = new();

            List.AddToList(new Dot(0, 0));
            List.AddToList(new Line(0f, 0f));
            List.AddToList(new Circle(0f, 0f));
            List.AddToList(new Rectangle(0f, 0f));
            List.AddToList(new Treangle(0f, -0.5f));
            List.AddToList(new Rhombus(0f, 0f));    

            List.PrintList(new Render());

            System.Console.ReadLine();
        }
    }
}
