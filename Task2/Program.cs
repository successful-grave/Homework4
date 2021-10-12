using System;

namespace Task2
{
    class Program
    {
        // Пользователь вводит одно число (A).
        // Найдите количество положительных целых чисел, квадрат которых меньше A.
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int A = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i < Math.Sqrt(A); i++)
            {
                if(Math.Pow(i, 2) < A)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество положительных целых чисел, квадрат которых меньше A: {count}");
        }
    }
}
