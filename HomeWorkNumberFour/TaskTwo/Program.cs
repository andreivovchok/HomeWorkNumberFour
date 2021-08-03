using System;
using System.Collections.Generic;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringNumbers = new List<string>();
            int maxValue = 500;
            
                for (int minValue = 200; minValue < maxValue; minValue++)
                {
                    if(minValue % 17 == 0)
                    {
                    stringNumbers.Add(minValue.ToString());
                    }
                }
            string result = string.Join(", ", stringNumbers);
            Console.Write(result);
        }
    }
}
