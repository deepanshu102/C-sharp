using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    public delegate int MyDel(int a, int b);
    class Maths_Addition
    {
        public static int sum(int a,int b) { return (a + b); }
    }
     class lab2_pro19
    {
        public static void Main()
        {
            MyDel fun = new MyDel(Maths_Addition.sum);
            Console.WriteLine("Sum=" + fun(20, 40));
        }
    }
}
