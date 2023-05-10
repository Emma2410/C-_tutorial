using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access1
{
    class Three
    {
        // Consuming members of  a class from non-child class 
        static void Main()
        {
            Program p = new Program();
            p.Test2();p.Test4();p.Test4();
            Console.ReadLine();
        }
    }
}
