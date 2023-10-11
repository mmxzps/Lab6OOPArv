using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    //Creating the base class "Animal".
    internal class Animal
    {
        //The properites that the animals shares, and default values
        public string Name { get; set; } = "N/A";
        public int Age { get; set; } = 0;
        public int Eyes { get; set; } = 2;
        public int Ears { get; set; } = 2;
        public int Legs { get; set; } = 4;
        public int Mouth { get; set; } = 1;
        public int Tail { get; set; } = 1;

        //A constructor for making new animals.
        public Animal(string name, int age)
            
        {
            Name = name;
            Age = age;

        }

        //Methods that the animals shares.
        public void walk()
        {
            Console.WriteLine($"{Name} is walking" );
        }

        public void eat()
        {
            Console.WriteLine($"{Name} is eating!");
        }

        public void jump()
        {
            Console.WriteLine($"{Name} jumpings!");
        }
    }

    //creating a tame/wild interface
    public interface IWild
    {
        void Wild();
    }
    public interface ITame
    {
        void Tame();
    }
}


