using System;
using System.Collections.Generic;
using System.Text;

namespace labrab
{
    class TEPiramid : TETriangle
    {
        private uint _height;

        public uint Height
        {
            get => _height;
            set
            {
                _height = value;
            }
        }

        public TEPiramid()
        {

        }
        public TEPiramid(uint edgeLength, uint height)
        {
            EdgeLength = edgeLength;
            Height = height;
        }
        public TEPiramid(TEPiramid piramid)
        {
            EdgeLength = piramid.EdgeLength;
            Height = piramid.Height;
        }

        public override void OutputFields()
        {
            Console.WriteLine($"Edge Length = {EdgeLength}\nHeight = {Height}");
        }

        public override void InputFields()
        {
            bool isWrong = true;
            uint tmp;
            // Check for incorrect numbers in edge length
            while (isWrong)
            {
                Console.WriteLine("Input Edge Length:");
                tmp = Convert.ToUInt32(Console.ReadLine());

                if (tmp > 0)
                {
                    EdgeLength = tmp;
                    isWrong = false;
                }
                else
                {
                    Console.WriteLine("Incorrect number. Try again. ");
                }
            }
            
            isWrong = true;
            // Check for incorrect numbers in height
            while (isWrong)
            {
                Console.WriteLine("Input Height:");
                tmp = Convert.ToUInt32(Console.ReadLine());

                if (tmp > 0)
                {
                    Height = tmp;
                    isWrong = false;
                }
                else
                {
                    Console.WriteLine("Incorrect number. Try again. ");
                }
            }
        }

        public void FindVolume()
        {
            double result;
            // V = (h * pow(a,2)) / (4 * √3)
            // h - height, a - EdgeLength
            result = (Height * Math.Pow(EdgeLength, 2)) / (4 * Math.Sqrt(3));

            Console.WriteLine($"Volume of Pyramid = {result}");
        }
    }
}
