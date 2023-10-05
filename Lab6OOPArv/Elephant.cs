using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Elephant : Animal
    {
        public string Trunk = "Trunk";
        public void Showers()
        {

        }
        public void makeSound()
        {
            Console.WriteLine($"{Name} says: *Toot*");
        }
    }
}
