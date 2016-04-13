using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface implementation to create Interface instance
namespace DemoInterfaces
{
    public interface IAnimal
    {
        string Speak();
    }
    public class Animal : IAnimal
    {
        public string Speak()
        {
            return "Animal Voice";
        }
    }
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Woof, woof";
        }
    }

    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow";
        }
    }

    public class Parrot : IAnimal
    {
        public string Speak()
        {
            return "Sqwark!";
        }
    } 

    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Writes Woof, Woof
        //    IAnimal animal = new Dog();
        //    Console.WriteLine(animal.Speak());

        //    // Now writes Meow
        //    animal = new Cat();
        //    Console.WriteLine(animal.Speak());

        //    // Now writes Sqwark etc
        //    animal = new Parrot();
        //    Console.WriteLine(animal.Speak());


        //    // Now writes Sqwark etc
        //    animal = new Animal();
        //    Console.WriteLine(animal.Speak());



            
        //    Console.ReadLine();
        //}
    }
}
