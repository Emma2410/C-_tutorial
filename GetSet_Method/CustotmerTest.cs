using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet_Method
{
    internal class CustotmerTest
    {
        static void Main()
        {
            Customer c = new Customer(101, true, "John", 5000.00);
            Console.WriteLine(c.Custid);
            
            if(c.Status == true )
            {
                Console.WriteLine("Active");
            }
            else
            {
                Console.WriteLine("In Active");
            }
            Console.WriteLine(c.Cname);
            c.Cname = "Emma";
            Console.WriteLine(c.Cname);
            Console.WriteLine(c.Balance);
            c.Balance= 100000;
            Console.WriteLine(c.Balance);
            Console.ReadLine();

        }
    }
}
