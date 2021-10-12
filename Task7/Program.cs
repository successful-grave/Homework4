using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит одно число произвольной длины (5-8 цифр).
            //Найти количество нечетных цифр этого числа.
            Console.Write("Введите число (5-8 цифр): ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            while(number > 0)
            {
                if((number % 10) % 2 != 0)
                {
                    count++;
                }
                number /= 10;
            }
            Console.WriteLine($"Количество нечетных цифр числа: {count}");
        }
    }
}
