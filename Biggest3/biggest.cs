using System;

class PrintInteger
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if(a>b && a > c)
        {
            Console.WriteLine("Biggest: "+a);
        }
        else if(b>a && b> c)
        {
            Console.WriteLine("Biggest: " + b);
        }
        else
        {
            Console.WriteLine("Biggest: " + c);
        }
    }
}