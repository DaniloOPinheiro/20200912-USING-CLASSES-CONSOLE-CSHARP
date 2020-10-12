using System;

namespace ConsoleClassExamples.ConsoleClass
{
    public class Example
    {
        public static void ConsoleExample(String name)
        {
            Console.Write("Hello ");
            Console.WriteLine("World!,");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Good day, ");
            Console.Write(name);
            Console.WriteLine("!");
        }
    }
}