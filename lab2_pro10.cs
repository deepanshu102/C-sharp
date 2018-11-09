using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    abstract class Shape
    {
        public abstract Double area();
        public abstract void Intial();

    }
    class Triangle : Shape
    {
        int s, a, b, c;
        public Triangle()
        {
            s = a = b = c = 0;
        }
        public override void Intial()
        {
            Console.WriteLine("Enter the All side length");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            s = (a + b + c) / 2;
        }
        public override double area()
        {

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
    class Square : Shape
    {
        int s;
        public Square()
        {
            s = 0;
        }
        public override void Intial()
        {
            Console.WriteLine("Enter the All side length");
            s = Convert.ToInt32(Console.ReadLine());
        }
        public override double area()
        {

            return Math.Pow(s, 2);
        }
    }
    class Rectangle : Shape
    {
        double l, b;
        public Rectangle()
        {
            l = b = 0;
        }
        public override void Intial()
        {
            Console.WriteLine("Enter the length of rectangle");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breath of Rectangle");
            b = Convert.ToDouble(Console.ReadLine());
        }
        public override double area()
        {

            return l * b;
        }
    }
    class lab2_pro10
    {
        public static void Main()
        {
            Shape[] obj = new Shape[3];
            obj[0] = new Triangle();
            obj[2] = new Rectangle();
            obj[1] = new Square();
            foreach(Shape obk in obj)
            {
                obk.Intial();
                Console.WriteLine("Area of {0}:-{1}", obk.GetType(), obk.area());
            }
            Console.Read();
        }
    }
}
