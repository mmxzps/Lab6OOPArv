using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Dog: Animal, ITame
    {
        //A propertie for dog, and default value
        public string Breed { get; set; } = "Husky";


        //A constructor for making new animals.
        public Dog(string name, int age) : base(name, age)
        {
        }

        //A method for dog
        public void playFetch()
        {
            Console.WriteLine($"{Name} like to play fetch");
        }

        //Make sound method
        public void makeSound()
        {
            Console.WriteLine($"{Name} says: *Woff*");
        }

        //categorising to the tame side
        public void Tame()
        {
            Console.WriteLine($"You can pet {Name} because its a tamed animal");
        }
    }
}
