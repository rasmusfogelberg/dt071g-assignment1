using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Which course are you studying now?");
            var course = Console.ReadLine();
            Console.WriteLine("What assignment is this? (first, second, third?");
            var assignment = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}.");
            Console.WriteLine($"{Environment.NewLine}You are currently studying the course {course}.");
            Console.WriteLine($"{Environment.NewLine}This is the {assignment} assignment on the course!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
