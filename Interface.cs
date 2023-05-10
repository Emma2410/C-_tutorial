using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction
{
    interface IAnimal
    {
        void animalSound();

    } 
    class Pig: IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The Pig says: Wee Wee");
        }

      
    }
    internal class Interface
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            
        }
    }

   
}
