using System.Collections.Generic;

namespace FractalNet
{
    public interface IFractal
    {
        int MaxIterations{get;set;}
        Point Center{get;set;}
        double ScaleFactor{get;set;}
        public List<int> 
        Calculate(Point leftUpCorner, Point pointsToProcess, Point step);
        

    }
}