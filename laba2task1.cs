using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Getting ex = new Getting(5, 5, 5, 3);
            Console.WriteLine("Ваш перший член прогрессії: " + ex.A1);
            Console.WriteLine("Ваш знаменник прогрессії: " + ex.Q);
            Console.WriteLine("Кількість елементів прогресії: " + ex.N);
            Console.WriteLine("Елемент, який треба знайти: " + ex.K);
            Console.WriteLine("Сума: " + ex.GetSumm(ex.N));
            Console.WriteLine("Шуканий елемент: " + ex.GetElem(ex.A1, ex.K));
            Console.ReadKey();
        }

        class Getting
        {
            protected double a1;
            protected double q;
            protected int n;
            protected int k;

            public Getting() { }
            public Getting(double a1, double q, int n, int k)
            {
                this.a1 = a1;
                this.q = q;
                this.n = n;
                this.k = k;
            }
            public double A1
            {
                get
                {
                    return a1;
                }
                set
                {
                    a1 = value;
                }
            }
            public double Q
            {
                get
                {
                    return q;
                }
                set
                {
                    q = value;
                }
            }
            public int N
            {
                get
                {
                    return n;
                }
                set
                {
                    n = value;
                }
            }
            public int K
            {
                get
                {
                    return k;
                }
                set
                {
                    k = value;
                }
            }
            public double GetElem(double a1, int k)
            {
                if (k == 1)
                {
                    return a1;
                }
                else
                {
                    return a1 * Math.Pow(q, k - 1);
                }
            }
            public double GetSumm(int n)
            {
                return a1 * ((1 - Math.Pow(q, n)) / (1 - q));
            }

        }
    }
}
