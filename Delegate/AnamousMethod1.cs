using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class AnamousMethod1
    {
        
        static void Main()
        {
            GreetinDelegate obj = delegate (string name)
            {
                return "Hello " + name + " a very good morning";
            };
            string s = obj.Invoke("Emma");
            Console.WriteLine(s);
            
            Console.ReadLine();
        }
    }
}
