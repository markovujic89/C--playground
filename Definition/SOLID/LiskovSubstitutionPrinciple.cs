using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definition.SOLID
{
    internal class LiskovSubstitutionPrinciple
    {
        public void ClientCode(Shape shape)
        {
            double area = shape.Area();
            Console.WriteLine("The area of the shape is: " + area);
        }

        //// Usage
        //Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
        //Square square = new Square { SideLength = 5 };

        //ClientCode(rectangle); // Output: The area of the shape is: 50
        //ClientCode(square); // Output: The area of the shape is: 25
    }

    // Base class
    public class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    // Derived classes
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Square : Shape
    {
        public double SideLength { get; set; }

        public override double Area()
        {
            return SideLength * SideLength;
        }
    }

}
