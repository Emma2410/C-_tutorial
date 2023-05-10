using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction_Exercise
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public class EnumConversionExample
    {
        public static void Main()
        {
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");

            var b = (Season)1;
            Console.WriteLine(b);

            var c = (Season)4;
            Console.WriteLine(c);
        }
    }

    
}
