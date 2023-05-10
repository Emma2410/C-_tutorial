using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction
{
    internal interface Interface1
    {
        void Add(int a, int b);
    }
    interface Interface2 : Interface1
    {
        void Sub(int a, int b);
    }
    class ImplementationClass: Interface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        static void Main()
        {
            ImplementationClass obj = new ImplementationClass();
            Interface2 i = obj;
            i.Add(100, 30);i.Sub(78, 23);
            
        }
    }
}
