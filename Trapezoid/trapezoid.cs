using System;

class PrintInteger
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float h = float.Parse(Console.ReadLine());

        float avarage = (float)((a + b) / 2) * h ;

        Console.WriteLine("Your avarage: " + avarage);
    }
}