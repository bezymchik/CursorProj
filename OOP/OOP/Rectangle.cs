using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Rectangle : BaseShape
    {
        private double width { get; set; }
        private double height { get; set; }
        public override double area { get; set; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            area = width * height;
        }
    }
}
