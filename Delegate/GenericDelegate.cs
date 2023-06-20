using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate double DelegateAdd(int x, float y, double z);
    public delegate void DelegateAdd2(int x, float y, double z);
    public delegate bool DelegateLength(string s);
    internal class GenericDelegate
    {
        public static double AddNum1(int x,float y, double z)
        {
          return x+y+z;
        }
        public static void AddNum2(int x,float y,double z) 
        {
            Console.WriteLine(x+y+z);
        }
        public static bool CheckLenght(string str)
        {
            if(str.Length > 5)
                return true;
            return false;

        }
        static void Main()
        {
            DelegateAdd d1 = AddNum1;
            double result = d1.Invoke(1, 2.2f, 3.4);
            Console.WriteLine(result);

            DelegateAdd2 d2 = AddNum2;
            d2.Invoke(1, 2.2f, 3.4);

            DelegateLength l = CheckLenght;
            bool result1 = l.Invoke("Hell");
            Console.WriteLine(result1);


            Console.ReadLine();
        }
    
    }
}
