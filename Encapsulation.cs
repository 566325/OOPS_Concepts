using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal class Encapsulation
    {
    }
    class Car
    {
        private int Speed;
        public int speed
        {
            get { return Speed; }
            set { Speed = value; } 
        }
        public void Print()
        {
            Console.WriteLine(speed);
        }
    }
    class Person
    {
        private string _name;
        private int _Age;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_Age);
        }
    }
}
