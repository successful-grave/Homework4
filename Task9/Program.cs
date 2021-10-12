using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пользователь вводит целое положительное  число (N).
            // Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
            Console.Write("Введите число N: ");
            uint N = uint.Parse(Console.ReadLine());
            for (uint i = 0; i < N; i++)
            {
                uint numb = i;
                uint sumOfEven = 0;
                uint sumOfOdd = 0;
                while (numb > 0)
                {
                    if ((numb % 10) % 2 == 0)
                    {
                        sumOfEven += numb % 10;
                    }
                    else
                    {
                        sumOfOdd += numb % 10;
                    }
                    numb /= 10;
                }
                if (sumOfEven > sumOfOdd)
                {
                    Console.Write($"{i}\t");
                }
            }
        }
    }
}
