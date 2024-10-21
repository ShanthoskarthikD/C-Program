using System;
class Program
{
    static void Main()
    {
        string number = "357546";
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        foreach (char digit in number)
        {
            Console.Write(words[int.Parse(digit.ToString())] + " ");
        }
    }
}
