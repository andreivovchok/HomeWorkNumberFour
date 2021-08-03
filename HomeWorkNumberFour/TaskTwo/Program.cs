using System;
using System.Collections.Generic;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strinrNumbers = new List<string>();
            int maxValue = 500;
            
                for (int minValue = 200; minValue < maxValue; minValue++)
                {
                    if(minValue % 17 == 0)
                    {
                    strinrNumbers.Add(minValue.ToString());
                    }
                }
            string result = string.Join(", ", strinrNumbers);
            Console.WriteLine(result);
        }
    }
}
