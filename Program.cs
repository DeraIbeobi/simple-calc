using System;
namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string operation;
            while(true)
            {
                System.Console.WriteLine("Enter the first number: ");
                if(double.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                System.Console.WriteLine("Invalid input, Enter a number");
            }
            

            while(true)
            {
                System.Console.WriteLine("Enter the second number: ");
                if(double.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                System.Console.WriteLine("Invalid input, Enter a number");
            }
            while(true)
            {
                System.Console.WriteLine("Enter a maths operation (+, -, *, /)");
                operation = Console.ReadLine();
                if(operation == "/" || operation == "-" || operation == "+" || operation == "*")
                {
                    break;
                }
                System.Console.WriteLine("Invalid input, enter a proper maths operation");
            }
            
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
                if(num2 == 0)
                {
                    System.Console.WriteLine("error dividing by zero");
                    return;
                }
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