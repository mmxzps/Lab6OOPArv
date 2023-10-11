using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Lion : Animal, IWild
    {
        //A propertie for lion, and default value
        public string LionMane { get; set; } = "Mane";

        //A constructor for making new animals.
        public Lion(string name, int age) : base(name, age)
        {
        }

        //A method for lion
        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting");
        }

        //Make sound method
        public void makeSound()
        {
            Console.WriteLine($"{Name} says: *Roar*");
        }

        //categorising to the wild side 
        public void Wild()
        {
            Console.WriteLine($"Be carefull! {Name} is a wild animal!");
        }
    }
}
