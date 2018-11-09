using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class A
    {
        private int a;
        public A()
        {
            Console.WriteLine("Object Created");
        }
         ~A()
        {
            Console.WriteLine("Object is Destroyed");
        }
    }
    class lab2_pro12
    {
        
        public static void Main()
        {
            Console.WriteLine("Enter how many object you want to created");
            int n = Convert.ToInt32(Console.ReadLine());
            { new A(); }
            for(int i=0;i<n;i++)
            {
               A obj= new A();
            }
            Console.ReadKey();
        }
    }
}
