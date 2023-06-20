using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction_Exercise
{
    interface ITestInterface
    {
        void Add(int a, int b);
    }
    interface ITestInterface2: ITestInterface
    {
        void Sub(int a , int b);
    }
    class ImplementationClass : ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a , int b)
        { 
            Console.WriteLine(a - b);
        }
        static void Main()
        {
            ImplementationClass obj = new ImplementationClass();
            obj.Add(100, 30);
            obj.Sub(100, 30);
            Console.ReadLine();
        }

    }

    
}
