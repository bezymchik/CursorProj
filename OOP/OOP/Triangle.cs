using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Triangle : BaseShape
    {
        private double basis { get; set; }
        private double height { get; set; }
        public override double area { get; set; }

        public Triangle(double basis, double height)
        {
            this.height = height;
            this.basis = basis;
            area = basis * height / 2;
        }
    }
}
