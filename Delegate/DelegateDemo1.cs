using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delegate.Properties
{
    // Step 1 : Define Delegate
    public delegate void addDelegate(int a, int b);
    public delegate string SayDelegate(string s);
    
    internal class DelegateDemo1
    {
        public void AddNum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string s)
        {
            return "Hello " + s;
        }
        public static void Main(string[] args)
        {
            DelegateDemo1 p= new DelegateDemo1();
            addDelegate ad = new addDelegate(p.AddNum);
            ad.Invoke(100, 50);
            SayDelegate sd = new SayDelegate(SayHello);
            //Console.WriteLine(sd);
            string str = sd("Jacob");
            Console.WriteLine(str);
            Console.ReadLine();
            //p.AddNum(1, 2);
            //string s = SayHello("Jab");
            //Console.WriteLine(s);
            //Console.ReadLine();
        }

    }
}


// to call a method by using a delegate we have 3 steps:
// 1 Define Delegate 

// 2 