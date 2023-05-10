using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction
{
    internal interface ITestInterface
    {
        void Add(int a,int b);
        
    }
    interface ITestInterface1 : ITestInterface 
    {
        static void main()
        {
            Console.WriteLine();
        }
    }



}
