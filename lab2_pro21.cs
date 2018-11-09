using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class MyControl
    {
        public delegate void MyEvent(int n);
        public event MyEvent Event;
        public void onEvent(int x)
        {
            if (Event != null)
                Event(x);
            else
            { Console.WriteLine("Event Not Raised"); }
        }

    }
    class lab2_pro21
    {
        static void EventHandler(int x)
        {
            Console.WriteLine("Event Occured");
            Console.WriteLine((x & 1) == 1 ? "Even number:- {0}" : "Odd number {0}", x);
        }
        public static void Main()
        {
            MyControl e = new MyControl();
            e.Event += lab2_pro21.EventHandler;
            e.onEvent(50);
        }
    }
}
