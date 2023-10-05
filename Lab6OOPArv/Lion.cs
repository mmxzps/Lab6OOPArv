using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Lion : Animal
    {
        public string LionMane = "Mane";

        public void Hunt()
        {

        }

        public void makeSound()
        {
            Console.WriteLine($"{Name} says: *Roar*");
        }
    }
}
