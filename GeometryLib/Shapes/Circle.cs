using GeometryLib.AbstractClasses;
using System;

namespace GeometryLib.Shapes
{
    public class Circle :AbstractShape
    {

        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius must be positive.");
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
