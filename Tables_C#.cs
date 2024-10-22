using System;
class Program
{
    static void Main(string[] args)
    {      
        int N = Convert.parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{N} x {i} = {N * i}");
        }
    }
}
