using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Greyhound : Dog, ITame
    {
        //A propertie for greyhound, and default value
        public string Body { get; set; } = "Skinny";

        //A constructor for making new animals.
        public Greyhound(string name, int age) : base(name, age)
        {
        }

        //A method for greyhound
        public void fastRunner()
        {
            Console.WriteLine($"{Name} is runing very fast!");
        }
        
    }
}
