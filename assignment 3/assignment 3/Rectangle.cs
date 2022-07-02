using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class Rectangle : Shape
    {
        public int length { get; set; }
        public int width { get; set; }
        public override double calculatearea()

        {
            return length * width;
        }
        public override double calculateperimeter()
        {
            return 2 * (length + width);
        }
    }
}
