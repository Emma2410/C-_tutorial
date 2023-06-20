using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    internal class Program
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(Width *  Height);
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(2 * (Width +Height));
        }
        static void Main(string[] args)
        {
            Program r = new Program();
            r.GetArea(10.1, 10.1);
            r.GetPerimeter(10.1, 10.1);

            Console.ReadLine();
        }
    }
}
