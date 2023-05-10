using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction_Exercise
{
    interface interface1
    {
        void Test();
    }
    interface interface2
    {
        void Test();
    }
    internal class MultipleInherienceTest :interface1,interface2
    {
        public void Test() {
            Console.WriteLine("Implement in child class");
        }
        static void Main()
        {
            MultipleInherienceTest obj = new MultipleInherienceTest();
            obj.Test();
        }
    }
}
