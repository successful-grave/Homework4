using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = int.Parse(Console.ReadLine());
            while(A != 0 && B != 0)
            {
                if(A > B)
                {
                    A %= B;
                }
                else
                {
                    B %= A;
                }
            }
            int NOD = A + B;
            Console.WriteLine($"НОД = {NOD}");
        }
    }
}
