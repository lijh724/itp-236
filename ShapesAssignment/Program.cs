using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ShapesAssignment
{
    internal class Program
    {
        static void Main(string[] args) // main method
        {
            Rectangle r1 = new Rectangle(20, 25);   // creates Rectangle object r1; Rectangle(l,w)

            ShowShape(r1);  // describes Rectangle r1 object


            Square s1 = new Square(5);  // creates Square object s1; Square(l)

            ShowShape(s1);  // describes Square s1 object


            var s2 = new Square();  // creates Square object s1 using var

            ShowShape(s2);  // describes Square s2 object


            Circle c1 = new Circle(10); // creates Circle object c1

            ShowShape(c1);  // describes Circle c1 object


            ReadKey();  // press key to exit console
        } // ends main

        static void ShowShape(Shape s)  // catches a shape
        {
            // s.GetType().Name identifies the shape name
            WriteLine($"{s.GetType().Name}\t\tArea = {s.Area}\t\tPerimeter = {s.Perimeter}\t\tUOM = {s.UoM}"); // \t is adding tabs to console display

            WriteLine();    // empty line
        } // ends ShowShape
    }
}
