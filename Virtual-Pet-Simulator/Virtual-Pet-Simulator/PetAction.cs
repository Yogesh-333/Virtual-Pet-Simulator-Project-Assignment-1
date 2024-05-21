using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Pet_Simulator
{
    internal class PetAction
    {
        PetDetails details= new PetDetails();
          public void Feed(int hunger,int health, string name)
        {
            hunger = Math.Max(hunger - 2, 0);
            health = Math.Min(health + 1, 10);
            Console.WriteLine($"{name} is fed. Hunger decreased, health slightly increased.");
        }

        public void Play(int hunger, int happiness, string name)
        {
            happiness = Math.Min(happiness + 2, 10);
            hunger = Math.Min(hunger + 1, 10);
            Console.WriteLine($"{name} played. Happiness increased, hunger slightly increased.");
        }

        public void Rest(int happiness, int health, string name)
        {
            health = Math.Min(health + 2, 10);
            happiness = Math.Max(happiness - 1, 0);
            Console.WriteLine($"{name} is resting. Health improved, happiness slightly decreased.");
        }

        public void Status(int hunger, int health,int happiness, string name)
        {
            Console.WriteLine($"\n{name}'s Status:");
            Console.WriteLine($"Hunger: {hunger}/10");
            Console.WriteLine($"Happiness: {happiness}/10");
            Console.WriteLine($"Health: {health}/10");
            if (hunger >= 8) Console.WriteLine($"{name} is very hungry!");
            if (happiness <= 2) Console.WriteLine($"{name} is very unhappy!");
            if (health <= 2) Console.WriteLine($"{name} is in poor health!");
        }

    }
}
