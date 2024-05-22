using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Pet_Simulator
{
     class PetAction
    {
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }

        public PetAction()
        {
            Hunger = 5;
            Happiness = 5;
            Health = 5;
        }



        public void Feed( string name)
        {
            Hunger = Math.Max(Hunger - 2, 0);
            Health = Math.Min(Health + 1, 10);
            Console.WriteLine($"{name} is fed. Hunger decreased, health slightly increased.");
        }

        public void Play(string name)
        {
            Happiness = Math.Min(Happiness + 2, 10);
            Hunger = Math.Min(Hunger + 1, 10);
            Console.WriteLine($"{name} played. Happiness increased, hunger slightly increased.");
        }

        public void Rest(string name)
        {
            Health = Math.Min(Health + 2, 10);
            Happiness = Math.Max(Happiness - 1, 0);
            Console.WriteLine($"{name} is resting. Health improved, happiness slightly decreased.");
        }

        public void Status(string name)
        {
            Console.WriteLine($"\n{name}'s Status:");
            Console.WriteLine($"Hunger: {Hunger}/10");
            Console.WriteLine($"Happiness: {Happiness}/10");
            Console.WriteLine($"Health: {Health}/10");
            if (Hunger >= 8) Console.WriteLine($"{name} is very hungry!");
            if (Happiness <= 2) Console.WriteLine($"{name} is very unhappy!");
            if (Health <= 2) Console.WriteLine($"{name} is in poor health!");
        }


    }
}
