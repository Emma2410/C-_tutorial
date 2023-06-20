using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Child can called parent, but parent cannot called child pure method
namespace Inherience
{
    class Class2 : Class1
    {
        public Class2() : b ase(10)
        {
            Console.WriteLine("Class two constuctor is called" );
        }
        public void Test3() 
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            // Class1 p =new Class1();
            // NOOOOO     p. Test2()

            Class1 p; // Variable of class 1
            Class2 c = new Class2();  // Instance of class2
            p = c;   /// reference of parent class
            p.Test2();
            //c.Test1();
            //c.Test3();
            Console.ReadLine();
        }
    }
}
