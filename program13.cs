using System;

namespace labsheet
{
    struct Student1
    {
        String name,enroll;
        static Student1()
        {
        }
        public Student1(String n="Deepanshu Gupta",String e="41550404417")
        {
            name=n;
            enroll=e;
           count++;
        }
        
        
        public static int count;
        public String Name
        {
            get {
                return name;
            }
        }
        public String Enrollment
        {
            get
            {
                return enroll;

            }
        }

    }
    class program13
    {
        public static void Main()
        {
			Console.Write("hello");
			Student1 s=new Student1("Deepanshu");
            Console.WriteLine("{0} \t {1} \t {2}", Student1.count, s.Name, s.Enrollment);
            Console.Read();
     }
  
    }
}
