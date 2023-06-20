using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction_Exercise
{
    abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x-y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
        static void Main()
        {
            //AbsParent p = new AbsParent();
            //p.Add(100, 50);
            //p.Sub(100, 50);
            //Console.ReadLine();
        }
        
    }
}
