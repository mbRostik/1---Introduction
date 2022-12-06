using System;

class FloatNumbers
{
    static void Main()
    {
        short a = short.Parse(Console.ReadLine());
        bool b;
        if ((a>20) && ((a % 2) != 0))
        {
            b = true;
        }
        else
        {
            b = false;
        }
        Console.WriteLine(b);
    }
}