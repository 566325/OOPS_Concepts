using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal class Inheritance
    {
    }
    public class Employee
    {
        int salary = 40000;

        public void Demo()
        {
            int salary = 40000;
            Console.WriteLine(salary);
        }
    }
    public class Programmer : Employee 
    {
        public float bonus = 10000;

        public void Demo1() 
        {
            int bonus = 40000;
            Console.WriteLine(bonus);
        }
    }
    public class Animal
    {
        public void cat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine(" Barking ...");
        }

    }
        
        
}
