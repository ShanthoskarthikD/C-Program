using System;
class SimpleInterest
{
    static void Main()
    {
        Console.Write("Enter principal: ");
        principal = Convert.Toint32(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        rate = Convert.Toint32(Console.ReadLine());

        Console.Write("Enter time (in years): ");
        time = Convert.Toint32(Console.ReadLine());

        interest = (principal * rate * time) / 100;
        Console.WriteLine("Simple Interest: " + interest);
    }
}
