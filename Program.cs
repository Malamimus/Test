using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            Console.Write("Количество рядов: ");
            if (r < 0 )
            {
                Console.Write("Что ж, сегодня обойдёмся без кинотеатров, удачи)");
                return ;
            }

            r =  Convert.ToInt32(Console.ReadLine());
            bool [][] ryads = new bool [r][];
        }
    }
}
