using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Square : BaseShape
    {
        private double side { get; set; }
        public override double area { get; set; }

        public Square(double side)
        {
            this.side = side;
            area = side * 4;
        }
    }
}
