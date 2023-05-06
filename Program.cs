using System;
namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the first number ");
            double num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the Second number ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a maths operation  (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;

            switch(operation)
            {
                case "+":
                result = num1 + num2;
                break;
                case "-":
                result = num1 - num2;
                break;
                case "*":
                result = num1 * num2;
                break;
                case "/":
                result = num1 / num2;
                break;
                default:
                System.Console.WriteLine("Invalid entry.");
                break;
            }
            System.Console.WriteLine("Result = " + result);
            Console.ReadKey();
        }
    }
}