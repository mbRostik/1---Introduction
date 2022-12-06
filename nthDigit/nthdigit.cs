using System;

class PrintInteger
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        double ndigit = (int)(a / Math.Pow(10, n - 1))%10;
        Console.WriteLine("N-digit = "+ndigit);
    }
}