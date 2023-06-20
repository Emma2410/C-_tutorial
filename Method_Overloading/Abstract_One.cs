using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
   
    abstract class Animal
    {
        public abstract void Animalsound();


        public void sleep()
        {
            Console.WriteLine("XXx");
        }
    }

    class Pig : Animal {
        public override void Animalsound()
        {
            Console.WriteLine("This Pig says Wee");
        }

    }


    internal class Abstract_One
    {
        static void Main(string[] args)
        {
            Pig mypig = new Pig();
            mypig.Animalsound();
            mypig.sleep();

        }


    }




}

