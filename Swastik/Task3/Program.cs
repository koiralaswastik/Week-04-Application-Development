using System;

class Program
{
    static void Main(string[] args)
    {
        // creating object
        ParameterDemo demo = new ParameterDemo();

        // calling Increase 
        int myNumber = 20;
        demo.Increase(ref myNumber);
    Console.WriteLine("Number after Increase: " + myNumber);

        // calling GetFullName 
        string myFullName;
        demo.GetFullName(out myFullName);
        Console.WriteLine("Full Name: " + myFullName);
        int sumResult = demo.SumAll(5, 10, 15, 20);
        Console.WriteLine("Sum of numbers: " + sumResult);
    }
}
