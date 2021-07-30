using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 500;
            while (true)
            {
                for (int minValue = 200; minValue < maxValue; minValue++)
                {
                    if(minValue % 17 == 0)
                    {
                        Console.Write($"{minValue},");
                    }
                }
                break;
            }
        }
    }
}
