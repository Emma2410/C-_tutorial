using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInherience
{

    interface Interface1
    {
        void Test();
        void Show();

    }
    interface Interface2
    {
        void Test();
        //void Show();
    }
    internal class Program : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Interface Method implement in child class");

        }
        void Interface1.Show()
        {
            Console.Write("Interface Mehtod imlement in childd");
        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Test();

            Interface1 i1 = obj;
            i1.Show();
            Console.ReadLine();
        }
    }
}
