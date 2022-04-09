namespace NM1
{
    class PreRender
    {
        private protected const int windowWidth  = 120, windowHeight = 30;
        private protected const float charAspect = 7.0f / 16.0f, windowAspect = (float)windowWidth / windowHeight;

        public delegate bool IsFigure(float coordX, float coordY);

        //static private void ConsolePreparing()
        //{
        //    Console.SetWindowSize(windowWidth, windowHeight);
        //}
    }
}