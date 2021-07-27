using System;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число от 0 до 100");
            string s = Console.ReadLine();
            int numbers = int.Parse(s);


            
            if(numbers >= 0 && numbers <= 30)
            {
                Console.WriteLine("Вы в первом промежутке!");
            }
            else if(numbers >= 31 && numbers <= 60)
            {
                Console.WriteLine("Вы во втором промежутке!");
            }
            else if(numbers >= 61 && numbers <= 100)
            {
                Console.WriteLine("Вы в третьем промежутке");
            }
            else
            {
                Console.WriteLine("Я не знаю такого числа!");
            }
            
        }
    }
}
