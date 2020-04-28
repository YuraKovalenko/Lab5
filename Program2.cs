using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lab5_2_Csharp
{
    class Program
    {
        class Figures//базовий клас
        {
            protected double a, b, r, pi = 3.14;
            public Figures(double x)
            {
                r = x;
            }
            public Figures(double x, double y)
            {
                a = x;
                b = y;
            }
            //віртуальні функції
            public virtual void Perimeter()
            {
                double p = 2 * (a + b);
                Console.WriteLine("Perimetr is:" + p);
            }
            public virtual void Area()
            {
                double s = a * b;
                Console.WriteLine("Area is:" + s);
            }
        }

        class Rectangle : Figures//похідний клас
        {
            private double x, y;
            public Rectangle(double x, double y) : base(x,y)
            {
                this.x = x;
                this.y = y;
            }
            public double Length()
            {
                return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            }
            public override void Area()
            {
                a = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                b = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                double s = a * b;
                Console.WriteLine("Area is:" + s);
            }
            public override void Perimeter()
            {
                a = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                b = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                double p = 2 * (a + b);
                Console.WriteLine("Perimetr is:" + p);
            }
        }

        class Circle : Figures//похідний клас
        {
            private double r;
            public Circle(double x) : base(x)
            {
                r = x;
            }
            public override void Area()
            {
                double s = pi * r * r;
                Console.WriteLine("Area is:" + s);
            }
            public override void Perimeter()
            {
                double p = 2 * pi * r;
                Console.WriteLine("Perimetr is:" + p);
            }
        }

        static void Solve()
        {
            Console.WriteLine("Kovalenko Yura IS-92");
            Rectangle a = new Rectangle(3, 4);
            Console.WriteLine("For Rectangle");
            a.Area();
            a.Perimeter();
            Circle b = new Circle(5);
            Console.WriteLine("For Circle");
            b.Area();
            b.Perimeter();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Solve();
        }
    }
}
