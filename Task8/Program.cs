using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пользователь вводит одно число.
            // Найти число, которое является зеркальным отображением
            // последовательности цифр заданного числа, например, задано число 123, вывести 321.
            // Просьба массивами и строками не пользоваться.
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int newNumber = 0;
            if(number < 10)
            {
                Console.WriteLine("Однозначное число невозможно отразить зеркально");
            }
            else
            {
                while(number > 0)
                {
                    newNumber *= 10;
                    newNumber += (number % 10);
                    number /= 10;
                }
                Console.WriteLine($"{newNumber}");
            }
        }
    }
}
