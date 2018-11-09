using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class HumanBeings
    {
        protected String name;
              public virtual String Name
        {
            get { return name; }
            set
            {
                if (value.Equals(" "))
                {
                    name = "Deepanshu";
                }
                else
                { name = value; }
            }
        }
    }
    class Person:HumanBeings
    {
        private String  address;
        public virtual void insert()
        {
            Console.Write("Enter the Name:- ");
            Name = Console.ReadLine();
            Console.Write("Enter the Address:- ");
            Address = Console.ReadLine();
        }
        public virtual void display()
        {
            Console.WriteLine("Name:-{0}\tAddress:-{1}", Name, Address);
        }
        public Person(String na="Deepanshu",String ad="2558/194")
         {
            this.Name = na;
            this.address = ad;
        }
        public new  String Name
        {
            get { return name; }
            set
            {
                if (value.Equals(" "))
                {
                    name = "Deepanshu";
                }
                else
                { name = value; }
            }
        }
        ~Person()
        {

        }
     
        public String Address
        {
            set
            {
                address = value;
            }
            get { return address; }
        }

    }
    class Student : Person
    {
        private String enroll, Batch, course;
        public String Enroll
        {
            set
            {
                if (value.Equals(" "))
                    value = "41550404417";
                enroll = value;
            }
            get { return enroll; }
        }
        public String batch
        {
            set
            {
                if (value.Equals(""))
                    value = "2017-2020";
                Batch = value;

            }
            get
            {
                return Batch;
            }
        }
        public string Course
        {
            get { return course; }
            set
            {
                if (value.Equals(""))
                    value = "MCA";
                course = value;
            }
        }
        public Student(String n="Deepanshu",String add="2558/194",String course="MCA",String Batch="2017-2020",String enroll="41550404417")
        {
            Name = n;
            Address = add;
            Enroll = enroll;
            this.Batch = Batch;
            Course = course;
        }
        public override void display()
        {
            Console.WriteLine("Name:- {0}\t Address:- {1}\nCourse:-{2}\tBatch:- {3}\t Enroll:- {4}",Name,Address,Course,batch,Enroll);
        }
        public override void insert()
        {
            Console.Write("Enter your name:- ");
            Name = Console.ReadLine();
            Console.Write("Enter the Address :- ");
            Address = Console.ReadLine();
            Console.Write("Enter the Course:- ");
            Course = Console.ReadLine();
            Console.Write("Enter the Batch:- ");
            Batch = Console.ReadLine();
            Console.Write("Enter the Enrollment Number:-");
            Enroll = Console.ReadLine();
        }
    }


    
    class lab2_pro14
    {
    public static void Main()
        {
        Student s =new Student();
            Person p = new Person();

            p.insert();
            p.display();
            p = s;
            p.insert();
            p.display();

        }
    }
}
