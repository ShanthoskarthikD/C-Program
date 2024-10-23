using System;
class FibonacciSeries
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());
        int a = 0, b = 1, sum = 0;
        Console.Write("Fibonacci Series: " + a + " " + b + " ");
        for (int i = 2; i < terms; i++)
        {
            int next = a + b;
            Console.Write(next + " ");
            sum += next;
            a = b;
            b = next;
        }
        sum += 1;
        Console.WriteLine("\nSum of Fibonacci Series: " + sum);
    }
}
