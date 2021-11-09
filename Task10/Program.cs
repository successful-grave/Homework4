using System;

namespace Task10
{
    class Program
    {
        // Пользователь вводит два числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
        // Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());
            while(firstNumber > 0)
            {
                int d1 = firstNumber % 10;
                while(secondNumber > 0)
                {
                    int d2 = secondNumber % 10;
                    if(d1 == d2)
                    {
                        Console.WriteLine("ДА");
                        break;
                    }
                }
                firstNumber /= 10;
                secondNumber /= 10;
            }
        }
    }
}
