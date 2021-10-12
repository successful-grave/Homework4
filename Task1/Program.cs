using System;

namespace Task1
{
    //Пользователь вводит одно число (A). Вывести все числа от 1 до 1000, которые делятся на A.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int A = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 1000; i++)
            {
                if(i % A == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
