using System;

namespace Task6
{
    class Program
    {
        // Пользователь вводит целое положительное число, которое является кубом целого числа N.
        // Найдите число N методом половинного деления.
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()); // куб введённого числа
            int left_edge = 0;
            int right_edge = number;
            double eps = 0.001; //погрешность
            int root; //искомое число
            while(right_edge - left_edge > eps)
            {
                int middle = (left_edge + right_edge) / 2; //находим середину

                int middle_func = (int)Math.Pow(middle, 3); //считаем куб числа, который посередине интервала

                int start_func = (int)Math.Pow(left_edge, 3); //считаем куб числа на левой границе

                int end_func = (int)Math.Pow(right_edge, 3); //считаем куб числа на правой границе

                if(start_func * middle_func <= 0)
                {
                    right_edge = middle;
                    end_func = middle_func;
                }
                else
                {
                    left_edge = middle;
                    start_func = middle_func;
                }
            }
            root = (left_edge + right_edge) / 2;
            Console.WriteLine($"Искомый корень: {root}");

            //тестировал на числе 27 в последний раз
            //сайт выдал ответ 0.0005257
            //У меня получилось 0.0004, что укладывается в eps
            //по идее всё правильно, но хто знает))
        }
    }
}
