using System;

namespace SimpleAdditionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dodawanie = new Dodawanie();

            Console.WriteLine("Enter first number:");
            if (!int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.WriteLine("This is not a valid number.");
                return;
            }

            Console.WriteLine("Enter second number:");
            if (!int.TryParse(Console.ReadLine(), out int number2))
            {
                Console.WriteLine("This is not a valid number.");
                return;
            }

            int result = dodawanie.Add(number1, number2);

            Console.WriteLine($"The sum of {number1} and {number2} is {result}");
        }
    }
}
