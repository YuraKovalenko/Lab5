using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Csharp
{
    class Program
    {
        class Point
        {
            protected double x, y;
            public Point(double ValueX,double ValueY)
            {
                x = ValueX;
                y = ValueY;
            }

            public double Length()
            {
                return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            }
        }

        class SecondPoint : Point
        {
            private char S;
            public SecondPoint(double x, double y, char s) : base(x,y)
            {
                this.S = s;
            }
            public void Foo()
            {
                char[] Arr = { 'q', 'w', 'e', 'r', 't', 'y', };
                for (int i = 0; i < 6; i++) 
                {
                    Console.WriteLine(" " + Arr[i]);
                }
                //Console.WriteLine("\n");
                Console.WriteLine("Enter s1 for replace: ");
                char s1 = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < 6; i++)
                {
                    if(Arr[i]==S)
                    {
                        Arr[i] = s1;
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(" " + Arr[i]);
                }
            }
        }

        static void Solve()
        {
            Console.WriteLine("My string is:");
            Console.WriteLine("q w e r t y");
            Console.WriteLine("Enter symbol for replace:");
            char symbol = Convert.ToChar(Console.ReadLine());
            if (symbol == 'q' || symbol == 'w' || symbol == 'e' || symbol == 'r' || symbol == 't' || symbol == 'y')
            {
                SecondPoint a = new SecondPoint(3, 4, symbol);
                a.Foo();
                Console.WriteLine("Enter X:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Y:");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Length is: " + a.Length());
            }
            else
            {
                Console.WriteLine("ERROR!!!\n");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Solve();
        }
    }
}
