using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>()
            {
                new Rectangle(2, 2),
                new Circle(2),
                new Triangle(2, 3),
                new Trapezoid(2, 4, 5)
            };

            foreach (Figure f in figures)
            {
                Console.WriteLine(f.GetArea());
            }
        }
    }
}
