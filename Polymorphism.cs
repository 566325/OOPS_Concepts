using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal class Polymorphism
    {
        //operator overloading
        public void Operations()
        {
            int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine(z);

            String a = " Sireesha";
            string b = "Nethi";
            string c = a + b;
            Console.WriteLine(c);
        }
    }
    public class Demo
    {
        // Method overloading
        public void Addition(int a, int b, int c)
        {
            int z = a + b + c;
            Console.WriteLine(z);
        }
        public void Addition(int a, int b)
        {
            int Z = a + b;
            Console.WriteLine(Z);
        }
    }
    //Method overriding

    public class Demo1
    {
        public virtual double Area()
        {
            return 0;
        }


    }
    public class Circle : Demo1
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 5;
        }
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);

        }
    }
    public class Square : Demo1
    {
        public double Length { get; set; }
        public Square()
        {
            Length = 5;
        }
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
}
