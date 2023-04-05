using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Definition.SOLID.OpenClose
{
    public class OpenClosePrinciple
    {
    }

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return 3.14 * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }

    public class AreaCalculator
    {
        public double TotalArea(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }

//    In this example, we have an abstract "Shape" class with an abstract "Area" method.We also have two concrete subclasses, 
//        "Circle" and "Rectangle," that implement the "Area" method.

//The "AreaCalculator" class takes an array of "Shape" objects and calculates the total area of all the shapes in the array.
//        Notice that we didn't have to modify the "AreaCalculator" class when we added new shapes to the hierarchy;
//        we simply had to create a new subclass of "Shape" with its own implementation of the "Area" method.

//This example follows the Open-Closed Principle because we've kept our existing classes closed for modification while still allowing them to be extended by creating new subclasses.
}
