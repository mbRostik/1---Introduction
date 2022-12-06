using System;

class FloatNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if( (a>0 && b>0 && c>0) || ((a<0&&b<0)||(a < 0 && c < 0)||(b < 0 && c < 0)))
        {
            Console.WriteLine("Positive");
        }
        else
        {
            Console.WriteLine("Negative");
        }
    }
}