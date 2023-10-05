using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Animal
    {
        public string Name;
        public int Age;
        public int Eyes = 2;
        public int Ears = 2;
        public int Legs = 4;
        public int Mouth = 1;
        public int Tail = 1;

        public interface IWild
        {
            void Wild();
        }
        public interface ITame
        {
            void Tame();
        }
        public Animal()
        {

        }
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
}
