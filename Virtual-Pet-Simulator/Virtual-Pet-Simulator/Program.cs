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
            Console.WriteLine($"Welcome, {pet.Name} the {pet.Type}!");        }
    }
}