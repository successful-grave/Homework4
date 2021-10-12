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
            double number = double.Parse(Console.ReadLine()); // куб введённого числа
            double left_edge = 0;
            double right_edge = number;
            double eps = 0.001; //погрешность
            double root; //искомое число
            while(right_edge - left_edge > eps)
            {
                double middle = (left_edge + right_edge) / 2; //находим середину


                double middle_func = middle; //считаем куб числа, который посередине интервала
                for(int i = 0; i < 3; i++)
                {
                    middle_func *= middle;
                }
                double start_func = left_edge; //считаем куб числа на левой границе
                for (int i = 0; i < 3; i++)
                {
                    start_func *= left_edge;
                }
                double end_func = right_edge; //считаем куб числа на правой границе
                for (int i = 0; i < 3; i++)
                {
                    end_func *= right_edge;
                }


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
