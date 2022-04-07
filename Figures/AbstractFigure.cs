namespace NM1
{
    abstract class Figure
    {
        private protected float coordX0, coordY0;
        public Figure(float coordX, float coordY)
        {
            this.coordX0 = coordX;
            this.coordY0 = coordY;
        }
        public virtual bool IsFigure(float coordX, float coordY)
        {
            return true; //Figure formula
        }
    }
}