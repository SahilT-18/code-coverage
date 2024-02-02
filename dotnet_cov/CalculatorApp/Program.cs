using System;

namespace CalculatorApp {
class Program
{
    static void Main()
    {
        var calculator = new Calculator();

        Console.WriteLine($"Addition: {calculator.Add(5, 3)}");
        Console.WriteLine($"Subtraction: {calculator.Subtract(5, 3)}");
        Console.WriteLine($"Multiplication: {calculator.Multiply(5, 3)}");
        Console.WriteLine($"Division: {calculator.Divide(6, 2)}");
    }
}
}
