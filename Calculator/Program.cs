using System;
using System.Linq;


namespace С_Course
{
    internal class Program
    {
        // Method to input and validate parameters: first number, mathematical operator,
        // and second number
        static void enterParam(out double num1, out string mathSign, out double num2)
        {
            num1 = getValidDouble("Enter first number: ");
            mathSign = getValidOperator();
            num2 = getValidDouble("Enter second number: ");
        }
        // Method to validate user input for a number and ensure it's a valid double
        static double getValidDouble(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Invalid number! Please, try aggain!");
            }
        }
        // Method to validate user input for a valid mathematical operator from the allowed set
        static string getValidOperator()
        {
            string[] allowedSignes = { "+", "-", "*", "/", "%", "^" };
            while (true)
            {
                Console.Write("Enter mathematical sign (+, -, *, /, %, ^): ");
                string mathSign = Console.ReadLine()?.Trim();

                if (allowedSignes.Contains(mathSign))
                {
                    return mathSign;
                }
                Console.WriteLine($"Invalid operator! Allowed: {string.Join(" ", allowedSignes)}");
            }
        }
        // Method to prompt the user if they want to quit or continue the program
        static bool quitProgram()
        {
            Console.WriteLine();
            bool process = true;
            Console.WriteLine("Enter \"q\" if you want to quit or press Enter to continue");
            string quit = Console.ReadLine();
            if (quit.Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                process = false;
                Console.Clear();
                Console.WriteLine("Thank you! Bye!");
            }
            Console.WriteLine();
            return process;
        }
        static void Main(string[] args)
        {
            bool process = true;
            while (process)
            {
                Console.Clear();
                double num1,
                      num2;
                string mathSign;

                enterParam(out num1, out mathSign, out num2); // Collects input values

                switch (mathSign)
                {
                    case "+":
                        double sum = num1 + num2;
                        Console.Write($"{num1} + {num2} = {sum}");
                        break;
                    case "-":
                        double dif = num1 - num2;
                        Console.Write($"{num1} - {num2} = {dif}");
                        break;
                    case "*":
                        double mult = num1 * num2;
                        Console.Write($"{num1} * {num2} = {mult}");
                        break;
                    case "/":
                        double div;
                        if (num2 == 0)
                        {
                            Console.WriteLine("You cannot divide number by 0");
                        }
                        else
                        {
                            div = num1 / num2;
                            Console.Write($"{num1} / {num2} = {div}");
                        }
                        break;
                    case "%":
                        double mod = num1 % num2;
                        Console.Write($"{num1} % {num2} = {mod}");
                        break;
                    case "^":
                        if (num2 == 0)
                        {
                            Console.WriteLine($"{num1}^{num2} = 1");
                        }
                        else
                        {
                            double result = Math.Pow(num1, num2);
                            Console.WriteLine($"{num1}^{num2} = {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Please, enter only +, -, *, ^, / or %");
                        break;
                }
                Console.WriteLine();
                process = quitProgram(); // Checks if the user wants to continue
            }
            Console.ReadLine();
        }
    }
}
