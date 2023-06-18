using System;

public class ArithmeticOperations
{

    public static void Main(String[] args)
    {
        PerformOperation();

    }

    public static void PerformOperation()
    {
        Console.WriteLine("beep boop first number required");
        string? input1 = Console.ReadLine();

        if (string.IsNullOrEmpty(input1))
        {
            Console.WriteLine("Invalid input. Does not compute beep");
            return;
        }

        double num1;
        if (!double.TryParse(input1, out num1))
        {
            Console.WriteLine("Invalid number format. Does not compute beep");
            return;
        }

        Console.WriteLine("second number required beep boop");
        string? input2 = Console.ReadLine();

        if (string.IsNullOrEmpty(input2))
        {
            Console.WriteLine("Invalid input. Does not compute beep");
            return;
        }

        double num2;
        if (!double.TryParse(input2, out num2))
        {
            Console.WriteLine("Invalid number format. Does not compute beep");
            return;
        }

        Console.WriteLine("beep requires operator: +, -, *, or /, boop");
        string? operationInput = Console.ReadLine();

        if (string.IsNullOrEmpty(operationInput) || operationInput.Length != 1)
        {
            Console.WriteLine("Invalid operation input. Does not compute beep");
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
                Console.WriteLine("Does not compute.");
                return;
        }

        Console.WriteLine("beep boop result: " + result);
    }
}
