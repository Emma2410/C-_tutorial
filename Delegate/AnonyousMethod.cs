using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string GreetinDelegate(String name);
    internal class AnonyousMethod
    {
        public  static string  Greeting(string  name)
        {
            return "Hello " + name + " a very good morning";
        }
        static  void Main()
        {
            GreetinDelegate  obj= new GreetinDelegate(Greeting);
            string str = obj.Invoke("Emma 1");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
