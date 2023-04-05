using Definition.Abstract_Class;
using Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definition.Abstract_Class
{
    internal class AbstractClassExample
    {
    }

    //In this example, Shape is an abstract class that has an abstract method GetArea() and a non-abstract method PrintCoordinates().
    //It also has incomplete implementation, as it only defines the x and y coordinates of a shape,
    //but leaves the specific calculation of its area to its derived classes.

    //The Circle and Rectangle classes inherit from the Shape class and implement their own versions of the GetArea() method.
    //They also have their own constructors that set their specific properties (radius for Circle and width and height for Rectangle).

    //Note that the Shape class cannot be instantiated directly, but can be used as a base class for other classes.
    //Also note that the Circle and Rectangle classes implement the GetArea() method as required by the Shape class,
    //but they can also have their own additional methods and properties.

    public abstract class Shape
    {
        protected int x, y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double GetArea();

        public void PrintCoordinates()
        {
            Console.WriteLine("Coordinates: ({0}, {1})", x, y);
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(int x, int y, double radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        private int width, height;

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }
}


