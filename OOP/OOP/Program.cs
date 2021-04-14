using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new List<BaseShape>
            {
                new Rectangle(25, 20),
                new Circle(10),
                new Square(36),
                new Triangle(20, 20),
                new Circle(25),
                new Triangle(15, 26),
                new Rectangle(7, 40),
                new Rectangle(7.232D, 78.245D),
                new Circle(500)
            };

            var sorted_shape = ShapeSort(shape);
            
        }
        static List<BaseShape> ShapeSort(List<BaseShape> list)
        {
            var sorted_areas_list = new List<double>();
            var sorted_shape_list = new List<BaseShape>(); 
            foreach(var i in list)
            {
                sorted_areas_list.Add(i.area);  // Sorting areas
            }
            sorted_areas_list.Sort();

            foreach(var i in sorted_areas_list) // Sorting shapes by areas
            {
                foreach(var j in list)
                {
                    if (i == j.area)
                    {
                        sorted_shape_list.Add(j);
                        break;
                    }
                }
            }
            return sorted_shape_list;
        }
    }
}
