using System;
class ConvertNumbers
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryInput = Console.ReadLine();
        int integer = Convert.ToInt32(binaryInput, 2);
        Console.WriteLine("Integer representation: " + integer);
    }
}
