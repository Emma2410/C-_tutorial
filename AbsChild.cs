using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction_Exercise
{
    internal class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        static void Main()
        {
            AbsChild c = new AbsChild();
            //AbsParent p = c;
            c.Add(140, 45);
            c.Sub(150, 50);
            c.Mul(220, 34);
            c.Div(454, 34);
            Console.ReadLine();
        }
    }
}
