using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    public delegate void Mydel(int x);
    class lab2_pro20
    {
        public static void Main()
        {
            Mydel ob= (x=>{ for (int i = 0; i <= x; i++)
                    Console.WriteLine(i); });
            ob(10);
        }
    }
}
