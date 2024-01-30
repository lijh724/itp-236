using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAssignment
{
    public abstract class Shape
    {
        // constructor
        public Shape()
        {
            UoM = "inches";
        }

        public string UoM { get; set; }     // UoM = unit of measure

        public abstract double Area { get; }    // override in class

        public abstract double Perimeter { get; }   // override in class
    } // ends Shape

    // Rectangle object definition
    public class Rectangle : Shape
    {
        // constructor
        public Rectangle(double l, double w) : base()
        {
            Length = l;
            Width = w;
        }

        // default constructor; this is passing the Rectangle(l,w)
        public Rectangle() : this(1,1)
        {
            
        }

        public double Length { get; set; }

        public double Width { get; set; }

        public override double Area { get { return Length * Width; } }  // override Area

        public override double Perimeter { get { return (Length * Width) * 2; } }   // override Perimeter
    }

    // Square object definition
    public class Square : Shape
    {
        // constructor
        public Square(double l) : base()
        {
            Length = l;
        }

        // default constructor
        public Square() : this(1)
        {

        }

        public override double Area { get { return Length * Length; } } // override Area

        public override double Perimeter { get { return Length * 4; } } // override Perimeter

        public double Length { get; set; }
    }

    // Circle object definition
    public class Circle : Shape
    {
        // constructor
        public Circle(double r) : base()
        {
            Radius = r;
        }

        // default constructor
        public Circle() : this(1)
        {

        }

        public double Radius { get; set; }

        public override double Area { get { return Math.PI * Radius * Radius; } }   // override Area

        public override double Perimeter { get { return 2 *  Math.PI * Radius; } }  // override Perimeter
    }
}