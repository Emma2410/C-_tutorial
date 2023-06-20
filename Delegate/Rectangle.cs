using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void RectDelegate(double Width, double Height);


    internal class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(Width *  Height);
        }

        public  void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(2 * (Width +Height));
        }
        public static  void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            RectDelegate obj = new RectDelegate(r.GetArea);
            //obj.Invoke(10.1, 10.1);
            //RectDelegate obj2 = new RectDelegate(r.GetPerimeter);
            //obj2.Invoke(10.1, 10.1);
            obj += r.GetPerimeter;
            obj.Invoke(10, 10);
            obj.Invoke(20, 20);


            Console.ReadLine();
        }
    }
}
