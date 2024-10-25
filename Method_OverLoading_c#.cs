using System;
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
}
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Add(int, int): " + calc.Add(5, 10));      
        Console.WriteLine("Add(int, int, int): " + calc.Add(5, 10, 15));
        Console.WriteLine("Add(double, double): " + calc.Add(5.5, 10.5));
    }
}
