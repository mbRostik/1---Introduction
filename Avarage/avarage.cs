using System;

class FloatNumbers
{
    static void Main()
    {
        short a= short.Parse(Console.ReadLine());
        short b = short.Parse(Console.ReadLine());
        short c = short.Parse(Console.ReadLine());

        float avarage=((float)(a+b+c)/3);

        Console.WriteLine("Your avarage: "+avarage);
    }
}