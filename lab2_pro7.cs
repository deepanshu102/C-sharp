using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class lab2_pro7
    {
        public static void Main()
        {

            int num = 0;
            Console.WriteLine("Enter the list amount");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[k];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            k = Convert.ToInt32(Console.ReadLine());
            foreach (int p in a)
            {
                if (p == k)
                { num++; }
            }
            Console.WriteLine("{1} occurence in the list is :- {0}", num, k);
        }
    }
}
