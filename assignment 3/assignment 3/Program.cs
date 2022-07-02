using System;

namespace assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Rectangle r = new Rectangle();
            r.width = 5;
            r.length = 5;
            r.calculatearea();
            r.calculateperimeter();
            Console.WriteLine(" area of rectangle is" + r.calculatearea());
            Console.WriteLine(" perimeter of  is" + r.calculateperimeter());
            Circle c = new Circle();
            c.radius = 4;
            c.calculatearea();
            c.calculateperimeter();
            Console.WriteLine(" area of circle is" + r.calculatearea());
            Console.WriteLine(" perimeter of circle is" + r.calculateperimeter());

        }
    }
}
