using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class lab2_pro3
    {
        //(-b+=(b2-4ac)^1/2)/2a
        public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter the Co");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            double ab = b * b - 4 * a * c,d,d1;
            d = ((-b) + Math.Sqrt(ab)) / 2 * a;
            d1 = ((-b) - Math.Sqrt(ab)) / 2 * a;
            if (ab < 0)
                Console.WriteLine("Roots are Imaginary");
            else if (ab == 0)
                Console.WriteLine("Roots are Equal \nRoots are:\n {0}\t{1}",d,d1);

            else if (ab > 0)
                Console.WriteLine("Roots are Different \nRoot are :- \n{0}\t {1}",d,d1);
            Console.ReadKey();
        }
    }
}
