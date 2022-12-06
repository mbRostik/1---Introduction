using System;

class PrintInteger
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Last digit is: " + a%10);
    }
}