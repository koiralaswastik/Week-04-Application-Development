using System;

class Program
{
    static void Main(string[] args)
    {
        // creating object of Calculator
        Calculator calc = new Calculator();

        // calling void method
        calc.PrintWelcome();

        // calling Add method
        int addResult = calc.Add(5, 10);
        Console.WriteLine("Addition Result: " + addResult);

        // calling Multiply method with two numbers
        int multiResult1 = calc.Multiply(4, 3);
        Console.WriteLine("Multiply Result 1: " + multiResult1);

        // calling Multiply method using default value for num2
        int multiResult2 = calc.Multiply(7);
        Console.WriteLine("Multiply Result 2: " + multiResult2);
    }
}
