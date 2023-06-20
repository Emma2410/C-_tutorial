using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void CallbackMethodHandler(string message);
    class DelegateDemo
    {
        static void Main(string[] args)
        {
            DelegateDemo obj = new DelegateDemo();
            CallbackMethodHandler del1 = new CallbackMethodHandler(obj.CallbackMethod);

            DoSomework(del1);

            
        }
        // public static void DoSomeWork(CallbackMethodHandler del)
        //{
        //  Console.WriteLine("Roc")
        //}

        public static void DoSomework(CallbackMethodHandler del)
        {
            Console.WriteLine("Processing some Task");
            del("Pranaya");
        }

        public void  CallbackMethod(string message)
        {
            Console.WriteLine("Call Back Method Executed");
        }
    }
}
