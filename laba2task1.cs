using System;

namespace laba2
{
     class Program
    {
        
        private static void Main(string[] args)
        {
            
            var ex = new Getting(5, 5, 5);
            try
            {
                Console.WriteLine("Enter find element:");
                var findElement = int.Parse(Console.ReadLine());
                Console.WriteLine("Ваш перший член прогрессії: " + ex.FirstElement);
                Console.WriteLine("Ваш знаменник прогрессії: " + ex.Denominator);
                Console.WriteLine("Кількість елементів прогресії: " + ex.CountOfElements);
                Console.WriteLine("Елемент, який треба знайти: " + findElement);
                Console.WriteLine("Сума: " + ex.Sum());
                Console.WriteLine("Шуканий елемент: " + ex[findElement]);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            Console.ReadKey();
            }

        private class Getting
        {
            protected int countOfElements;
            protected double denominator;
            protected double firstElement;

            public Getting()
            {
                firstElement = 5;
                denominator = 5;
                countOfElements = 3;
            }

            public Getting(double firstElement, double denominator, int countOfElements)
            {
                this.firstElement = firstElement;
                this.denominator = denominator;
                this.countOfElements = countOfElements;
            }

            public double FirstElement
            {
                get => firstElement;
                set => firstElement = value;
            }

            public double Denominator
            {
                get => denominator;
                set => denominator = value;
            }

            public int CountOfElements
            {
                get => countOfElements;
                set => countOfElements = value;
            }

            public double this[int element]
            {
                get
                {
                    if (element > countOfElements)
                    {
                        throw new Exception("Element not found"); 
                    }
                    if (element == 1)
                    {
                        return firstElement;
                    }
                    return firstElement * Math.Pow(denominator, element - 1);
                }
            }

            public double Sum()
            {
                return firstElement * ((1 - Math.Pow(denominator, countOfElements)) / (1 - denominator));
            }
        }
    }
}
