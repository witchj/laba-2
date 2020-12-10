using System;

namespace Laba2Task2
{
    public class TETriangle
    {
        protected int _edgeLength;

        public TETriangle()
        {
            _edgeLength = 5;
        }

        public TETriangle(int edgeLength)
        {
            EdgeLength = edgeLength;
        }

        public TETriangle(TETriangle triangle)
        {
            EdgeLength = triangle.EdgeLength;
        }

        public int EdgeLength
        {
            get => _edgeLength;
            set
            {
                if (value <= 0) throw new ArgumentException("Incorrect value");
                _edgeLength = value;
            }
        }

        public override string ToString()
        {
            return $"Edge lenght:{EdgeLength}\nArea:{Area()}\nPerimetr:{Perimeter()}";
        }

        public double Area()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(EdgeLength, 2);
        }

        public double Perimeter()
        {
            return Math.Pow(EdgeLength, 3);
        }

        public static bool operator >(TETriangle triangle, TETriangle triangle2)
        {
            return triangle.EdgeLength == triangle2.EdgeLength;
        }

        public static bool operator <(TETriangle triangle, TETriangle triangle2)
        {
            return triangle.EdgeLength != triangle2.EdgeLength;
        }

        public static int operator *(TETriangle triangle, int number)
        {
            return triangle.EdgeLength * number;
        }

        public static int operator *(int number, TETriangle triangle)
        {
            return number * triangle.EdgeLength;
        }
    }
}
