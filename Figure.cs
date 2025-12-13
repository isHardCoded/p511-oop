using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public abstract class Figure
    {
        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class Circle : Figure
    {
        private const double PI = 3.14159;
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return PI * Radius * Radius;
        }
    }

    public class Triangle : Figure
    {
        public double Leg1 { get; set; }
        public double Leg2 { get; set; }

        public Triangle(double leg1, double leg2)
        {
            Leg1 = leg1;
            Leg2 = leg2;
        }

        public override double GetArea()
        {
            return 0.5 * Leg1 * Leg2;
        }
    }

    public class Trapezoid : Figure
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }

        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double GetArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }
    }
}
