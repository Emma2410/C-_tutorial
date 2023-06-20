using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

 
    class First
    {
        public int x = 100;
    }
    class Second {
        public int x;
    }
    class Third {
        public int x; //class variable
      
        public Third(int x) { // local variable
            this.x = x;
        }
    }
    class Test_Classes
    {


        static void Main()
        {
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine(f1.x + " " + f2.x + " " + f3.x);

            Second s1 = new Second();
            Second s2 = new Second();
            Second s3 = new Second();
            Console.WriteLine(s1.x + " " + s2.x + " " + s3.x + " ");

            Third t1 = new Third(100);
            Third t2 = new Third(200);
            Third t3 = new Third(300);
            Console.WriteLine(t1.x + " " + t2.x + " " + t3.x + " ");
            Console.ReadLine();

        }
    }

}
