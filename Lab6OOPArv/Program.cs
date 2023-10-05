using Lab6OOPArv;
using System.Runtime.InteropServices;

namespace Lab6Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion1 = new Lion();
            lion1.Name = "Lejon";
            lion1.Age = 12;
            Console.WriteLine($"{lion1.Name} is {lion1.Age} years old and has a {lion1.LionMane}");
            lion1.makeSound();
            lion1.jump();

            Console.WriteLine();

            Dog dog1 = new Dog();
            dog1.Name = "Malte";
            dog1.Age = 9;
            Console.WriteLine($"{dog1.Name} is a {dog1.Breed}");
            dog1.playFetch();
            dog1.makeSound();

            Console.WriteLine();

            Elephant elephant1 = new Elephant();
            elephant1.Name = "The Elephant";
            elephant1.Age = 10;
            Console.WriteLine($"{elephant1.Name}  has a {elephant1.Trunk}");
            elephant1.makeSound();
            elephant1.eat();
            Console.WriteLine();


            Greyhound grey1 = new Greyhound();
            grey1.Name = "Greyhound";
            grey1.Age = 11;
            Console.WriteLine($"{grey1.Name} is {grey1.Body}");
            grey1.makeSound();

            Console.WriteLine();

            Bulldog bulldog1 = new Bulldog();
            bulldog1.Name = "Bulldog";
            bulldog1.Age = 12;
            Console.WriteLine($"{bulldog1.Name} has a {bulldog1.Head} head");
            bulldog1.walk();
            bulldog1.makeSound();
        }
        
    }

}
