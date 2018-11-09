using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class lab2_pro28
    {
        public static void Main()
        {
            int[] a = { 8,7, 5, 4, 3, 6, 2, 1, 9, 10 };
            foreach(var k in a)
            {
                Console.Write(k +"\t");
            }
            Console.WriteLine();
            var lin = from n in a orderby n select n;
            foreach(var k in lin)
            {
                Console.Write(k+" \t");
            }
        }
    }
}
