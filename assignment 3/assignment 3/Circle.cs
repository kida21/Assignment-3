using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
     class Circle : Shape
    {
        public int radius { get; set; }

        public readonly double PI = 3.14;
        public override double calculatearea()

        {
            return radius * radius * PI;
        }
        public override double calculateperimeter()
        {
            return 2 * PI * radius;
        }
    }
}
