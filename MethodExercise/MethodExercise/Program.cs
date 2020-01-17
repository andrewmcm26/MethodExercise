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

            //Console.WriteLine(Mult(3.8, 49.2));
            //Console.WriteLine("Enter your first number:");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter your second number:");
            //double y = Convert.ToDouble(Console.ReadLine());
            ////Console.WriteLine("Your answers are (Addition Subtraction, Multiplication, Division):");

            ////Console.WriteLine(Sum(x, y));
            ////Console.WriteLine(Dif(x, y));
            ////Console.WriteLine(Mult(x, y));
            ////Console.WriteLine(Div(x, y));
            //////Console.WriteLine(Sum(4, 5));
            ////Console.WriteLine(Mult(10, 5));
            //Console.WriteLine($"The sum of your numbers is {Sum(x, y)} ");
            Sum(3.14, 4.8324);
        }
            //Beginning Exercise #2 creating math operators
            public static void Sum(double x, double y)
            { 
                 
                Console.WriteLine(x + y);
            }

        public static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public static void Sum(int x, int y, bool isBool)
        {

            if (isBool == true)
                if (x + y == 1)
                    Console.WriteLine($"{x + y} dollar");
                else
                    Console.WriteLine($"{x + y} dollars");
                   


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
