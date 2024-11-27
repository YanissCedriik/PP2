using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammering2
{
    public class Pet
    {
        public string Name { get; set; } 
        public int Age { get; set; }
        public int Hunger { get; set; }
        public int Happines { get; set; }
        public bool PottyTime { get; set; }

        public Pet(string name, int age, int hunger, int happines, bool pottyTime)
        {
            Name = name;
            Age = age;
            Hunger = hunger;
            Happines = happines;
            PottyTime = pottyTime;
        }
    }
}
