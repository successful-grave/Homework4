using System;
namespace Task4
{
    class Program
    {
        // Пользователь вводит два числа (A и B).
        // Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
        // (Учтите, что при вводе B может оказаться меньше A)
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = int.Parse(Console.ReadLine());
            int sum = 0;
            if (A == B)
            {
                Console.WriteLine("\aДиапазон не может быть равен нулю");
            }
            if (A > B)
            {
                int tmp = A;
                A = B;
                B = tmp;
            }
            for (int i = A; i <= B; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма чисел, которые делятся без остатка на 7: {sum}");
        }
    }
}
