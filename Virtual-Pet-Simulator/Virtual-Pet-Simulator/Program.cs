using System;
using Virtual_Pet_Simulator;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Pet Simulator!");
            Console.Write("Choose a pet type (e.g., cat, dog, rabbit): ");
            string type = Console.ReadLine();

            Console.Write("Give your pet a name: ");
            string name = Console.ReadLine();

            PetDetails pet = new PetDetails(name,type);
            PetAction action = new PetAction();
            Console.WriteLine($"Welcome, {pet.Name} the {pet.Type}!");

            bool running = true;

            while (running) {
                action.Status(name);                
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Exit");
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
                        Console.WriteLine("Goodbye!");
                        continue;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }
            }
        }
    }
}