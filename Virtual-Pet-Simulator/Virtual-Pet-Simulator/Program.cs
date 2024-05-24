using System;
using Virtual_Pet_Simulator;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtils.WriteColored("Welcome to the Virtual Pet Simulator!", ConsoleColor.Cyan);

            Console.Write("Choose a pet type (e.g., cat, dog, rabbit): ");
            string type = Console.ReadLine();

            Console.Write("Give your pet a name: ");
            string name = Console.ReadLine();

            PetDetails pet = new PetDetails(name,type);
            PetAction action = new PetAction();
            ConsoleUtils.WriteColored($"Welcome, {pet.Name} the {pet.Type}!", ConsoleColor.Green);
            ConsoleUtils.DrawPet(type);
            bool running = true;

            while (running) {
                action.Status(name);
                ConsoleUtils.WriteColored("\nChoose an action:", ConsoleColor.Cyan);
               // ConsoleUtils.DrawPetEmoji(type);// emoji not working 
                ConsoleUtils.WriteColored("1. Feed", ConsoleColor.Green);
                ConsoleUtils.WriteColored("2. Play", ConsoleColor.Yellow);
                ConsoleUtils.WriteColored("3. Rest", ConsoleColor.Blue);
                ConsoleUtils.WriteColored("4. Exit", ConsoleColor.Red);
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        action.Feed(name);
                        break;
                    case "2":
                        action.Play(name);
                        break;
                    case "3":
                        action.Rest(name);
                        break;
                    case "4":
                        running = false;
                        ConsoleUtils.WriteColored("Goodbye!", ConsoleColor.Cyan);
                        continue;
                    default:
                        ConsoleUtils.WriteColored("Invalid choice. Try again.", ConsoleColor.Red);
                        continue;
                }
            }
        }
    }
}