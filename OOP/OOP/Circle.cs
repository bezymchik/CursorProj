using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Circle : BaseShape
    {
        private double radius { get; set; }
        public override double area { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
            area = System.Math.PI * radius;
        }
    }
}
