using GeometryLib.AbstractClasses;
using System;

namespace GeometryLib.Shapes
{
    public class Triangle : AbstractShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }


        public Triangle(double a, double b, double c)
        {
            A = a; B = b; C = c;

            if (!IsValidTriangle())
                throw new ArgumentException("Impossible triangle");
        }

        public override double GetArea()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));

        }
        private bool IsValidTriangle()
        {
            return A + B > C && A + C > B && B + C > A;
        }


        public bool IsRight()
        {
            double[] sides = new[] { A, B, C };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-5;
        }

    }
}
