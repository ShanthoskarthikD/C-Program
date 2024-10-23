using System;
class ConvertNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2);
        Console.WriteLine("Binary : " + binary);
    }
}
