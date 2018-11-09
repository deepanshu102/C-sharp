using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class MyException : Exception
    {
        String s;
        public MyException(String s="")
        {
            this.s = s;          
        }
        public String S
        {
            get { return s; }
        }
    }
    class Profile
    {
        String name;
        public String Name
        {
            set
            {
                if(value[0]>='A')
                {
                    throw new MyException("FIRST LETTER OF YOU NAME SHOULD BE CAPITAL");
                }
                else { name = value; }
            }
            get { return name;

            }
        }
    }
    class lab2_pro15
    {
        public static void Main()
        {
            Profile p = new Profile(); 
            try
            {
                p.Name = "deepanshu";
                Console.WriteLine("name is {0}", p.Name);
            }
            catch(MyException e)
            {
                Console.Write(e.S);
            }
        }
    }
}
