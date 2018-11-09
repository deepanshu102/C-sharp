using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    public delegate int Mydele(int x);
    class lab2_pro25
    {
        public static void Main()
        {
            int A = 0;
            Mydele fun = x => x + 2;
            while(A<10)
            {
                Console.WriteLine("It's incremented by 2 using Lamda function {0}", A);
                A = fun(A);
            }
        }
    }
}
