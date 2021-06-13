using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0, s = 0;
            Console.Write("Количество рядов: ");
            r = Convert.ToInt32(Console.ReadLine());
            if (r <= 0)
            {
                Console.Write("Что ж, сегодня обойдёмся без кинотеатров, удачи)");
                return;
            }
            bool[][] ryads = new bool[r][];
            for (int i = 0; i < r; i ++ )
            {
                Console.Write($"Введите количество мест в ряду номер {i+1}: ") ;
                s = Convert.ToInt32(Console.ReadLine());
                ryads[i] = new bool[s];
            }
        }
    }
}
