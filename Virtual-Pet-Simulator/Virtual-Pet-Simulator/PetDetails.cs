using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Simulator
{
    class PetDetails
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }
        public PetDetails(string name, string type)
        {
            Name = name;
            Type = type;
            Hunger = 5;
            Happiness = 5;
            Health = 5;
        }
    }
}
