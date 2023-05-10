using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * class A {
 *          -member
 * }
 * class B : A {
 *  -comsume a member from A here
  */
 
namespace Inherience
{
    class Class1
    {
        public Class1(int i) {
            Console.WriteLine("Class 1 Constructor" + i);
        }
        public void Test1() 
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
        static void Main(string[] args)
        {
            Object obj = new Object();
            Console.WriteLine(obj.GetType());
            //Class1 c = new Class1();
            //Console.WriteLine(c.GetType());

        }
    }
}
