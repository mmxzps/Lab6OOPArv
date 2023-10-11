using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Bulldog : Dog, ITame
    {
        //A propertie for bulldog, and default value
        public string Head { get; set; } = "big";

        //A constructor for making new animals.
        public Bulldog(string name, int age) : base(name, age)
        {
        }

        //A method for bulldog
        public void slowRun()
        {
            Console.WriteLine($"{Name} runs slow ");
        }
    }
}
