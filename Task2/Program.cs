using System;
using Task2;

internal class Program
{
    static void Main(string[] args)
    {
        // Create object of Calculator
        Calculator calc = new Calculator();

        // Call void method
        calc.PrintWelcome();

        // Call Add method
        int addition = calc.Add(111, 222);
        Console.WriteLine("Addition Result: " + addition);

        // Call Multiply method (both parameters)
        int multiply1 = calc.Multiply(55, 80);
        Console.WriteLine("Multiplication (55 * 80): " + multiply1);

        // Call Multiply method (optional parameter)
        int multiply2 = calc.Multiply(2);  // num2 uses default = 1
        Console.WriteLine("Multiplication (2 * default): " + multiply2);

        Console.ReadLine();
    }
}