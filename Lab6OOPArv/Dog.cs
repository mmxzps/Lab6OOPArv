using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Dog: Animal
    {
        public string Breed = "Husky";

        public void playFetch()
        {
            Console.WriteLine($"{Name} like to play fetch");
        }
        public void makeSound()
        {
            Console.WriteLine($"{Name} says: *Woff*");
        }
        public void playSound()
        {

        }
    }
}
