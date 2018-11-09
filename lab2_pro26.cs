using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    public delegate double MyFacLog(int a);
    class lab2_pro26
    {
        public static void Main() {
            MyFacLog fac = (x => { double sum = 1; for (int i = 1; i <= x; i++)
                { sum *= i;
                }
                return sum; });
            Console.WriteLine("Factorial of 5 is " +fac(5));
        }
    }
}
