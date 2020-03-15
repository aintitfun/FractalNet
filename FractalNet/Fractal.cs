using System.Collections.Generic;

namespace FractalNet
{
    public abstract class Fractal : IFractal
    {
        public int MaxIterations {get;set;}
        public Point Center{get;set;}
        public double ScaleFactor{get;set;}


        public abstract List<int> Calculate(Point leftUpCorner, Point pointsToProcess, Point step);

    }
}