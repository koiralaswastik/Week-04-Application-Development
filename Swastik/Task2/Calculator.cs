using System;

public class Calculator
{
    // void method
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // method with return type int
    public int Add(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum;
    }

    // method with optional parameter
    public int Multiply(int num1, int num2 = 1)
    {
        int result = num1 * num2;
        return result;
    }
}
