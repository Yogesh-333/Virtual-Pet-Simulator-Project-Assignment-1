using System;

namespace VirtualPet
{
    static class ConsoleUtils
    {
        public static void WriteColored(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void DrawPet(string type)
        {
            switch (type.ToLower())
            {
                case "cat":
                    Console.WriteLine(" /\\_/\\ ");
                    Console.WriteLine("( o.o )");
                    Console.WriteLine(" > ^ < ");
                    break;
                case "dog":
                    Console.WriteLine(" / \\__");
                    Console.WriteLine("(    @\\___");
                    Console.WriteLine(" /         O");
                    Console.WriteLine("/   (_____/");
                    Console.WriteLine("/_____/   U");
                    break;
                case "rabbit":
                    Console.WriteLine(" (\\(\\ ");
                    Console.WriteLine("(-.-)");
                    Console.WriteLine(" o_(\")(\")");
                    break;
                default:
                    Console.WriteLine(" (\\_/)");
                    Console.WriteLine("(o.o)");
                    Console.WriteLine("(\")(\")");
                    break;
            }
        }

        public static void DrawPetEmoji(string type)
        {
            switch (type.ToLower())
            {
                case "cat":
                    Console.WriteLine("🐱");                   
                    break;
                case "dog":
                    Console.WriteLine("🐶");
                   
                    break;
                case "rabbit":
                    Console.WriteLine("🐰");
                   
                    break;
                default:
                    Console.WriteLine("🐼");
                    
                    break;
            }
        }
    }
}
