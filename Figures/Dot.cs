namespace NM1
{
    class Dot: Figure 
    {
        public Dot(float coordX, float coordY): base(coordX, coordY)
        {
            this.coordX0 = coordX;
            this.coordY0 = coordY;
        }
        public override bool IsFigure(float coordX, float coordY)
        {
            return (coordX == coordX0) && (coordY == coordY0); //(coordX == X0) && (coordY == Y0)
        }
    }
}