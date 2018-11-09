
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    enum type { Saving,Current,RD,FD};
    class Bank
    {
        private String depositor;
        private long acc_no;
        private type acc_type;
        private long amount;
        public Bank(String s)
        {
            if (s.Equals("S"))
            {
                acc_type = type.Saving;
                amount = 10000;
            }
            else if (s.Equals("c"))
            {
                acc_type = type.Current;
                amount = 20000;
            }
            else if (s.Equals("F"))
            {
                acc_type = type.FD;
                amount = 5000;
            }
            else if (s.Equals("R"))
            {
                acc_type = type.RD;
                amount = 5000;
            }
        }
        public Bank()
        {
            acc_type = type.Saving;
            amount = 10000;          
          
        }

        public void initial()
        {
            Console.WriteLine("Enter the Depositor name :- ");
            depositor = Console.ReadLine();
            
            Console.WriteLine("Enter the Account type [S/C/R/F]:- ");

            String s = Console.ReadLine();
            s = s.ToUpper();
            char c = s[0];
            acc_type = c.Equals('F') ? type.FD : c.Equals('C') ? type.Current : c.Equals('R') ? type.RD : type.Saving;
            amount = acc_type.Equals(type.FD) ? 5000 : acc_type.Equals(type.Current) ? 20000 : acc_type.Equals(type.RD) ? 5000 : 10000;
        }
        public void deposit(long am)
        { amount += am;
        }
        public void Withdraw(long with_amount)
        {
            if (acc_type.Equals(type.Saving) && (amount - with_amount) > 10000) amount -= with_amount;
            else if (acc_type.Equals(type.FD) && (amount - with_amount) > 5000)
                amount -= with_amount;
            else if (acc_type.Equals(type.Current) && (amount - with_amount) > 20000)
                amount -= with_amount;
            else if (acc_type.Equals(type.RD) && (amount - with_amount) > 5000)
                amount -= with_amount;
            else
                Console.WriteLine("Sorry Insuficient Amount");
        }
        public void bal()
        {
            Console.WriteLine("\n_________________________________\n\tRecipt\nNAME:\t{0}\nType:\t{1}\nBalance\t{2}", depositor, acc_type, amount);
        }

    }
    class lab2_pro9
    {
        public static void Main(String[] args)
        {

            Bank person1 = new Bank();
            person1.initial();
            person1.Withdraw(5000);
            person1.deposit(30000);
            person1.Withdraw(4000);
            person1.bal();
            Console.ReadKey();
        }
    }
}
