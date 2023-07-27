using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14assg17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.PrintInfo();

            Rectangle rectangle = new Rectangle(2, 6);
            rectangle.PrintInfo();

            Triangle triangle = new Triangle(2, 6, 8);
            triangle.PrintInfo();
        }
    }
}
