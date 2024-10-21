using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w aplikacji KALKULATOR!");

            while (true)
            {

                try
                {
                    Console.WriteLine("Podaj proszę 1 liczbę:");
                    var number1 = GetInput();

                    Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/'.");
                    var operation = Console.ReadLine();

                    Console.WriteLine("Podaj proszę 2 liczbę:");
                    var number2 = GetInput();

                    var result = Calculate(number1, number2, operation);

                    Console.WriteLine($"Wynik Twojego działania to: {Math.Round(result, 2)}.\n");

                }
                catch (Exception ex)
                {
                    //logowanie do pliku
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static double GetInput()
        {
            if (!double.TryParse(Console.ReadLine(), out double input))
                throw new Exception("Podana wartość nie jest liczbą.\n");

            return input;
        }

        private static double Calculate(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("Wybrałeś złą operację!\n");
            }
        }
    }
}