using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string GreetingDelegate(string m);
    internal class LambdaExpress
    {
       
        static void Main()
        {
            GreetingDelegate obj = (name) =>
            {
                return "Hello " + name + " a very good morning";
            };
            string s = obj.Invoke("Raju");
            Console.WriteLine(s);
            Console.ReadLine();
        }
    
    }
}
