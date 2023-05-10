using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction
{
    internal interface Interface3
    {
        void Add(int a, int b);
    }
    interface Interface4 : Interface3
    {
        void Sub(int a, int b);
    }

    internal class ImplementationClass : Interface4
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
            obj.Add(100, 30); obj.Sub(78, 23);
            Console.ReadLine();
        }
    }
}
