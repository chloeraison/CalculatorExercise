using System;

public class ArithmeticOperations
{
    public static void PerformOperation()
    {
        Console.WriteLine("beep boop calculator asks for first number");
        string? input1 = Console.ReadLine();

        if (string.IsNullOrEmpty(input1))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        double num1;
        if (!double.TryParse(input1, out num1))
        {
            Console.WriteLine("Invalid number format");
            return;
        }

        Console.WriteLine("calculator asks for second number beep boop");
        string? input2 = Console.ReadLine();

        if (string.IsNullOrEmpty(input2))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        double num2;
        if (!double.TryParse(input2, out num2))
        {
            Console.WriteLine("Invalid number format");
            return;
        }

        Console.WriteLine("calculator requires +, -, *, or /, boop boop");
        string? operationInput = Console.ReadLine();

        if (string.IsNullOrEmpty(operationInput) || operationInput.Length != 1)
        {
            Console.WriteLine("Invalid operation input");
            return;
        }

        char operation = operationInput[0];

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                result = num1 / num2;
                break;

            default:
                Console.WriteLine("Invalid operation");
                return;
        }

        Console.WriteLine("beep boop result: " + result);
    }
}
