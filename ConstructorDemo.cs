using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConstructorDemo
    {
        static int y;
        int x;

        static ConstructorDemo() {

            Console.WriteLine("Stastic Constructor is called");

        }
        public ConstructorDemo()
        {
            Console.WriteLine("Non_stastic Constructor is called");
        }
        public static void Main()
        {
            Console.WriteLine("Main Method is called");

            ConstructorDemo d1 = new ConstructorDemo();
            Console.WriteLine(y);  // stastic variable is called directly
           // Console.WriteLine(x); /// Error can occur
            Console.WriteLine(d1.x); 
            Console.ReadLine();

        }

    }
}
