using System;

namespace HelloWorldUserEB
{
   public class Program
    {
        public static ConsoleKey keyPressed;

        public static void Main()
        {
            Console.WriteLine("Hello World!");
            while (keyPressed != ConsoleKey.Enter)
            {
                Console.WriteLine("\n Press the Enter key to end this program...");
                keyPressed = Console.ReadKey().Key;
            }
        }
    }
}
