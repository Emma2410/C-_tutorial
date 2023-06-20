using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
        

    }
    public class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Width*Height;
        }
    }

    

    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;

        }
        public override double GetArea()
        {
            return Radius*Pi*Radius;
        }
        
    }

    public class Cone : Figure
    {
        public Cone(double Radius,double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Pi*Radius*(Radius + Math.Sqrt(Height* Height + Radius));
        }
    }

    class TestFigures
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(45.67);
            Cone co = new Cone(34.98, 12.89);

            Console.WriteLine("Area of Rectangle : "+ r.GetArea());
            Console.WriteLine("Area of  Rectangle : "+ c.GetArea());
            Console.WriteLine("Area of  Rectangle : "+ co.GetArea());
            Console.ReadLine();
        }
    }
}

