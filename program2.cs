using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class program2
    {
        static void Main(String[] args)
        {

            Console.Write("Enter the Number:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            check_arm(a);
        }
        static void check_arm(int n)
        {
            int r, temp = n, sum = 0;
            while (temp > 0)
            {
                r = temp % 10;
                temp = temp / 10;
                sum += r * r * r;
            }
            Console.WriteLine(sum == n ? n + " is a Armstrong Number" : n + " is not a Armstrong Number");
            Console.ReadKey();
        }
    }
}
