using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet_Method
{
    class Circle
    {
        double _Radius = 5;
        public double Radius
        {
            get { return _Radius; }
            set
            {
                if (value > _Radius)
                {
                    _Radius = value;
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Circle c = new Circle();
                c.Radius = 55;
                double radius = c.Radius;

               // c.SetRadius(55);
               Console.WriteLine(radius);
            }
        }

    }
}