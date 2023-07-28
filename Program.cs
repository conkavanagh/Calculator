using System;

class Calculator
{
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");

        while (true)
        {
            Console.WriteLine("Available operations:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Exiting calculator. Goodbye!");
                break;
            }

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.WriteLine();
                continue;
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.WriteLine();
                continue;
            }

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = Calculator.Add(num1, num2);
                    break;
                case "2":
                    result = Calculator.Subtract(num1, num2);
                    break;
                case "3":
                    result = Calculator.Multiply(num1, num2);
                    break;
                case "4":
                    try
                    {
                        result = Calculator.Divide(num1, num2);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    continue;
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine();
        }
    }
}
