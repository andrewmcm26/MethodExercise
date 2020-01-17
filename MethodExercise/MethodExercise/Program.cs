using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite city?");
            var favCity = Console.ReadLine();
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Once upon a time there was a {favColor} {favAnimal} that " +
                $"lived in {favCity}, and someone named {name} thought it was really cool.");
        }
    }
}
