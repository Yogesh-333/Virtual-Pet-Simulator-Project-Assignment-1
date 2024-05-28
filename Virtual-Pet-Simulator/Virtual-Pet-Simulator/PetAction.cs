using System;
using VirtualPet;

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

        public void Feed(string name)
        {
            Hunger = Math.Max(Hunger - 2, 0);
            Health = Math.Min(Health + 1, 10);
            ConsoleUtils.WriteColored($"{name} is fed. Hunger decreased, health slightly increased.", ConsoleColor.Green);
        }

        public void Play(string name)
        {
            if (Hunger >= 8)
            {
                ConsoleUtils.WriteColored($"{name} is too hungry to play! Please feed your pet.", ConsoleColor.Red);
                return;
            }
            if (Health <= 2)
            {
                ConsoleUtils.WriteColored($"{name} is in poor health and cannot play! Please let your pet rest.", ConsoleColor.Red);
                return;
            }

            Happiness = Math.Min(Happiness + 2, 10);
            Hunger = Math.Min(Hunger + 1, 10);
            ConsoleUtils.WriteColored($"{name} played. Happiness increased, hunger slightly increased.", ConsoleColor.Yellow);
        }

        public void Rest(string name)
        {
            Health = Math.Min(Health + 2, 10);
            Happiness = Math.Max(Happiness - 1, 0);
            ConsoleUtils.WriteColored($"{name} is resting. Health improved, happiness slightly decreased.", ConsoleColor.Blue);
        }

        public void Status(string name) //Function to show the status of the pet
        {
            ConsoleUtils.WriteColored($"\n{name}'s Status:", ConsoleColor.Cyan);
            ConsoleUtils.WriteColored($"Hunger: {Hunger}/10", ConsoleColor.Red);
            ConsoleUtils.WriteColored($"Happiness: {Happiness}/10", ConsoleColor.Magenta);
            ConsoleUtils.WriteColored($"Health: {Health}/10", ConsoleColor.Green);

            if (Hunger >= 8)
            {
                ConsoleUtils.WriteColored($"{name} is very hungry! Feed your pet to allow playing.", ConsoleColor.Red);
            }
            if (Happiness <= 2)
            {
                ConsoleUtils.WriteColored($"{name} is very unhappy! Play with your pet to improve happiness.", ConsoleColor.Red);
            }
            if (Health <= 2)
            {
                ConsoleUtils.WriteColored($"{name} is in poor health! Rest your pet to improve its health.", ConsoleColor.Red);
            }
        }

        public void TimePasses()
        {
            Hunger = Math.Min(Hunger + 1, 10);// this action is added just to denote that for past 1 hour the pet has reduced in all aspects
            Happiness = Math.Max(Happiness - 1, 0);
            if (Hunger >= 8) Health = Math.Max(Health - 1, 0);
            if (Happiness <= 2) Health = Math.Max(Health - 1, 0);
            ConsoleUtils.WriteColored("An hour has passed...", ConsoleColor.Yellow);
        }
    }
}
