using System;
namespace DemoProject
{
    struct MyStruct
    {
        int i;
        public void Display() 
        {
            Console.WriteLine("Method in a  structure" + i);
        }
        static void Main()
        {
            
            MyStruct m1 = new MyStruct();
            m1.i = 2;
            m1.Display();
            Console.ReadLine();
        }

    }

}