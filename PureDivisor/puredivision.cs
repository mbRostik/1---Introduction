using System;

class FloatNumbers
{
    static void Main()
    {
        short a = short.Parse(Console.ReadLine());
        bool result;
        if ( (a%9==0) || (a%11==0) || (a%13==0))
        {
            result = true;
        }
        else
        {
            result = false;
        }
        Console.WriteLine(result);
    }
}