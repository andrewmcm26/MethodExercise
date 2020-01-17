using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {


            //Beginning Exercise #1 - writing a story with variables

            //Console.WriteLine("What is your favorite color?");
            //var favColor = Console.ReadLine();
            //Console.WriteLine("What is your favorite animal?");
            //var favAnimal = Console.ReadLine();
            //Console.WriteLine("What is your favorite city?");
            //var favCity = Console.ReadLine();
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //Console.WriteLine($"Once upon a time there was a {favColor} {favAnimal} that " +
            //    $"lived in {favCity}, and someone named {name} thought it was really cool.");

            //double x = Sum(1, 2);

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Mult(1, 2));
            //Console.WriteLine(Dif(1, 2));
            //Console.WriteLine(Div(1, 2));

            Console.WriteLine("Enter your first number:");
            double x = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            double y = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Your answers are (Addition Subtraction, Multiplication, Division):");

            Console.WriteLine(Sum(x, y));
            Console.WriteLine(Dif(x, y));
            Console.WriteLine(Mult(x, y));
            Console.WriteLine(Div(x, y));

        }
            //Beginning Exercise #2 creating math operators
            public static double Sum(double x, double y)
            { 
                 
                return x + y;
            }

            

            public static double Dif(double x, double y)
            {
                return x - y;
            }
          

            public static double Mult(double x, double y)
            {
                return x * y;
            }
   

            public static double Div(double x, double y)
            {
                return x / y;

            }
          
        


    }
}
