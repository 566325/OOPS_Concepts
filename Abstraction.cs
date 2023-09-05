using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal class Abstraction
    {
    }

    abstract class Animal2 //Abstract Class
    {
        public abstract void animalSound(); // abstract Method
        public void sleep()   //normal Method
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig2 : Animal2 //Derived
    {
        public override void animalSound()
        {
            Console.WriteLine("The Pig saye wee wee");
        }
    }

    // Interfaces -- Used to achieve Multiple inheritance as well as full abstraction. 
    //  Methods inside a interface are abstract methods means they are having name but they don't have body.

    public interface IDrawable
    {
        public void draw();
    }

    public class Rectangle : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }

    public class circle : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }

    public class square : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Draw Square");
        }
    }

}
