using System;

namespace Task3
{
    class Program
    {
        //Пользователь вводит одно число (A). Вывести наибольший делитель (кроме самого A) числа A
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int A = int.Parse(Console.ReadLine());
            for(int i = A / 2; i > 1; i--)
            {
                if(A % i == 0)
                {
                    Console.WriteLine($"Наибольший делитель для А: {i}");
                    break;
                }
            }
        }
    }
}
