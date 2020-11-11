using System;
using System.Collections.Generic;
using System.Text;

namespace labrab
{
    class TETriangle
    {
        private uint _edgeLength;
        public uint EdgeLength
        {
            get => _edgeLength;
            set
            {
                _edgeLength = value;
            }
        }

        public TETriangle()
        {

        }
        public TETriangle(uint edgeLength)
        {
            EdgeLength = edgeLength;
        }
        public TETriangle(TETriangle triangle)
        {
            EdgeLength = triangle.EdgeLength;
        }

        public override string ToString()
        {
            return "TETriangle, EdgeLenght = " + EdgeLength;
        }

        public virtual void OutputFields()
        {
            Console.WriteLine($"Edge Length = {EdgeLength}");
        }
        public virtual void InputFields()
        {
            bool isWrong = true;
            uint tmp;

            // Check for incorrect numbers
            while(isWrong)
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
        }

        
        public void FindArea()
        {
            double result;
            // S = (√3 / 4) * pow(a,2)
            result = (Math.Sqrt(3) / 4) * Math.Pow(EdgeLength, 2);
            Console.WriteLine($"Area of Triangle = {result}");
        }
        public void FindPerimeter()
        {
            double result;
            result = Math.Pow(EdgeLength, 3);
            Console.WriteLine($"Perimeter of Triangle = {result}");
        }

        public void ComparisonWith(TETriangle triangle)
        {
            if(EdgeLength == triangle.EdgeLength)
                Console.WriteLine("The triangles are equal");
            else
                Console.WriteLine("The triangles aren't equal");
        }

        public static uint operator *(TETriangle triangle, uint number)
        {
            return triangle.EdgeLength * number;
        }
        public static uint operator *(uint number, TETriangle triangle)
        {
            return number * triangle.EdgeLength;
        }
    }
}
