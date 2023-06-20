using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeExercise
{
    internal class Program
    {
        static void Main()
        {
            Type t = typeof(String);
           
            //Console.WriteLine(t);

            MethodInfo substr = t.GetMethod("Substring",
               new Type[] { typeof(int), typeof(int) });

            Console.WriteLine(substr);

            //Object result =
           //     substr.Invoke("Hello, World!", new Object[] { 7, 5 });
            //Console.WriteLine("{0} returned \"{1}\".", substr, result);
        }
    }
}
