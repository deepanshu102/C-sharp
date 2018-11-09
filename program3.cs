using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class program3
    {
        public static String toBinary(long a)
        {
            String s = "";
            while (true)
            {
                s += Convert.ToString(a % 2);
                a = a / 2;
                if (a == 0)
                    break;
            }
            return new String(s.Reverse().ToArray());
        }
        public static String toOctal(long a)
        {
            String s = "";
            while (true)
            {
                s += Convert.ToString(a % 8);
                a = a / 8;
                if (a == 0)
                    break;
            }
            return new String(s.Reverse().ToArray());
        }
        public static String toHexaDecimal(long a)
        {
            String s = "";
            while (true)
            {
                s += (a % 16) == 10 ? "A" : (a % 16) == 11 ? "B" : (a % 16) == 12 ? "c" : ((a % 16) == 13) ? "D" : (a % 16) == 14 ? "E" : (a % 16) == 15 ? "F" : Convert.ToString(a % 16);
                a = a / 16;
                if (a == 0)
                    break;
            }
            return new String(s.Reverse().ToArray());
        }
        static void Main()
        {
            Console.WriteLine("Enter the Decimal Value:- ");
            long a = Convert.ToInt64(Console.ReadLine());
        Invalid:
            Console.Write("\n1.)Decimal to Binary\n2.)Decimal to Octal\n3.)Decimal to Hexadecimal\nEnter your Choice:- ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (c)
            {
                case '1': Console.WriteLine("{0} is Binary Value of {1}", toBinary(a), a); break;
                case '2': Console.WriteLine("{0} is Octal value of {1}", toOctal(a), a); break;
                case '3': Console.WriteLine("{0} is Hexa Decimal Value is {1}", toHexaDecimal(a), a); break;
                default: Console.WriteLine("Kindly Choose Correct Option"); goto Invalid;
            }
            Console.ReadKey();
        }
    }
}
