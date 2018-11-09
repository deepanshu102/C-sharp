using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class lab2_pro16
    {
        public static void  Main()
        {
            String s = "deepanshu", sc;
            StringBuilder s1 = new StringBuilder(s);
            Console.WriteLine("Reverser String is " + new string(((s.ToString()).Reverse().ToArray())));
            s1.Append(" Gupta");
            Console.WriteLine("After Concate the String"+s1);
            s1.Replace('G', 'g');
            Console.WriteLine("Replace 'G' to 'g'"+s1);
            sc = String.Copy(s1.ToString());
            Console.WriteLine("Copied String {0}", sc);

            Console.Read();
        }
    }
}
