using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    //return different with same function name is not method overloading
    class Program
    {
        public void Test()
        {
            Console.WriteLine("No Parameter");
        }
        public void Test(int i)
        {
            Console.WriteLine("Integer Parameter" + i);
        }
        public void Test(int i, int j)
        {
            Console.WriteLine("Two Integer Parameter"+ i + j );
        }
        public void Test(string s)
        {
            Console.WriteLine("String Parameter" + s);
        }
        public string Test1()
        {
            return "Hello World";
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test("Hello");
            Console.ReadLine();
        }
    }
}
