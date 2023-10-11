using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Elephant : Animal, IWild
    {
        //A propertie for Elephant, and default value
        public string Trunk { get; set; } = "Trunk";


        //A constructor for making new animals.
        public Elephant(string name, int age) : base(name, age)
        {
        }

        //A method for elephant
        public void Showers()
        {
            Console.WriteLine($"The {Name} showers with its trunk");
        }

        //Make sound method
        public void makeSound()
        {
            Console.WriteLine($"{Name} says: *Toot*");
        }

        //categorising to the wild side 
        public void Wild()
        {
            Console.WriteLine($"Be carefull! {Name} is a wild animal!");
        }
    }
}
