using Lab6OOPArv;
using System.Runtime.InteropServices;

namespace Lab6Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The lion object and its funktions.
            Lion lion1 = new Lion("Mufasa", 13);
            Console.WriteLine($"{lion1.Name} is {lion1.Age} years old and has a {lion1.LionMane}");
            lion1.makeSound();
            lion1.jump();
            lion1.Hunt();
            lion1.Wild();

            //Divider/spacer
            Console.WriteLine();

            //The Dog object and its funktions.
            Dog dog1 = new Dog("Malte", 9);
            Console.WriteLine($"{dog1.Name} is a {dog1.Breed} breed");
            dog1.playFetch();
            dog1.makeSound();
            dog1.Tame();

            //Divider/spacer
            Console.WriteLine();

            //The Elephant object and its funktions.
            Elephant elephant1 = new Elephant("Elielfant", 10);
            Console.WriteLine($"{elephant1.Name}  has a {elephant1.Trunk}");
            elephant1.makeSound();
            elephant1.eat();
            elephant1.Showers();

            //Divider/spacer
            Console.WriteLine();

            //The Greyhound object and its funktions.
            Greyhound grey1 = new Greyhound("Gerigrey", 11);
            grey1.Breed = "GreyHound";
            Console.WriteLine($"{grey1.Name} is {grey1.Body} because its a {grey1.Breed}");
            grey1.makeSound();
            grey1.fastRunner();
            grey1.Tame();

            //Divider/spacer
            Console.WriteLine();

            //The Bulldog object and its funktions.
            Bulldog bulldog1 = new Bulldog("Bulidog", 12);
            Console.WriteLine($"{bulldog1.Name} has a {bulldog1.Head} head");
            bulldog1.walk();
            bulldog1.slowRun();
           
        }
        
    }

}
