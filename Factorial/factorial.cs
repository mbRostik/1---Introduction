using System;

class FloatNumbers
{
    static void Main()
    {
        short a = short.Parse(Console.ReadLine());
        int factorial = 1;
        for(int i = 1; i != a+1; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}