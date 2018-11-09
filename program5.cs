using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class program5
    {
        static void Main(String[] args)
        {
            int[][] a = new int[4][];
            a[0] = new int[1];
            a[1] = new int[2];
            a[2] = new int[4];
            a[3] = new int[5];
            a[0][0] = 1;
            a[1][0] = 2;
            a[1][1] = 4;
            a[2][0] = 6;
            a[2][1] = 8;
            a[2][2] = 10;
            a[2][3] = 12;
            a[3][0] = 9;
            a[3][1] = 11;
            a[3][2] = 13;
            a[3][3] = 15;
            a[3][4] = 17;
            for (int i = 0; i < 4; i++)
            {
                foreach (int k in a[i])
                    Console.Write("{0}\t", k);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
