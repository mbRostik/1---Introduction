using System;

class FloatNumbers
{
    static void Main()
    {
        string[] days = new string[7];
        days[0] = "Monday";
        days[1] = "Tuesday";
        days[2] = "Wednesday";
        days[3] = "Thursday";
        days[4] = "Friday";
        days[5] = "Saturday";
        days[6] = "Sunday";

        string str =Console.ReadLine();
        int a=0;
        try
        {
            a = Convert.ToInt32(str);
            a--;
            if (a < 0 || a >= 7)
            {
                Console.WriteLine("not valid");
            }
            else
            {
                Console.WriteLine("Your day: " + days[a]);
            }
        }
        catch
        {
            Console.WriteLine("not valid");
        }
    }
}