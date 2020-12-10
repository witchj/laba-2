using System;

namespace Laba2Task2
{
    public class TEPiramid : TETriangle
    {
        private int _height;

        public TEPiramid()
        {
            _height = 5;
        }

        public TEPiramid(int edgeLength, int height) : base(edgeLength)
        {
            Height = height;
        }

        public TEPiramid(TEPiramid piramid)
        {
            EdgeLength = piramid.EdgeLength;
            Height = piramid.Height;
        }

        public int Height
        {
            get => _height;
            set
            {
                if (value <= 0) throw new ArgumentException("Incorrect value");
                _height = value;
            }
        }

        public static bool operator >(TEPiramid piramid, TEPiramid piramid2)
        {
            return piramid.Volume() == piramid2.Volume();
        }

        public static bool operator <(TEPiramid piramid, TEPiramid piramid2)
        {
            return piramid.Volume() != piramid2.Volume();
        }


        public double Volume()
        {
            return Height * Math.Pow(EdgeLength, 2) / (4 * Math.Sqrt(3));
        }

        public override string ToString()
        {
            return $"Edge length{EdgeLength}\nHeight:{Height}\nVolume:{Volume()}";
        }
    }
}
