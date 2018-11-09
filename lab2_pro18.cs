using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class Person1
    {
        String name, address;
        public  String Name
        {
            set
            {
                name = value;
            }
            get { return name; }
        }
        public virtual String Address
        {
            get { return address; }
            set { address = value; }
        }
    }
    internal interface College
    {
         void display();

    }
   sealed class Student2:Person1,College
    {
        String enroll;
        const String Collg_name="JIMS",code= "IP1007";
       public void display()
        {
            Console.WriteLine("Name:-{0}\t Address:{1}\nCollege Name:-{3}\tCode:-{4}Enroll:-{2}", Name, Address, Enroll, Collg_name, code);
        }
        public String Enroll
        {
            get { return enroll; }
            set { enroll = value; }
        }
    }

    class lab2_pro18
    {
        public static void Main()
        {
           Student2 obj=new Student2();
            obj.Name = "Deepanshu";
            obj.Enroll = "41550404417";
            College g = obj;
            g.display();
        }
    }
}
