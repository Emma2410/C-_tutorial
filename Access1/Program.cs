using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access1
{
    public class Program
    {

        private void Test1()
        {
            Console.WriteLine("Private");
        }
        internal void Test2()
        {
            Console.WriteLine("Internal");
        }
         protected void Test3()
        {
            Console.WriteLine("Protected");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal");
        }
        public void Test5()
        {
            Console.WriteLine("Public Method");
        }
        static void Main(string[] args)
        {
            Program p  = new Program();
            p.Test1(); p.Test2(); p.Test3(); p.Test4();
            
        }
    }
}
