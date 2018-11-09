using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class lab2_pro11
    {
        public static void by_Ref(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
        public static void Main()
        {
            int a = 20, b = 0;
            Console.WriteLine("a={0} \t b={1}", a, b);
            by_Ref(ref a, ref b);
            Console.WriteLine("After Swap [Using Call by Refernces] a={0}\tb={1}", a, b);
            by_Ref(a, b);
            Console.WriteLine("After Swap[using Call by value] a={0}\tb={1}", a, b);
            Console.ReadKey();
        }
        public static void by_Ref(int a, int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
            
        }
    }

}
