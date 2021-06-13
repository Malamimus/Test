using System;
using System.Linq;

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
                ryads[i] = Enumerable.Repeat(true, s).ToArray();
            }
            int ask = 0;
            int rr;
            while (ask != 3)
            {
                Console.WriteLine("Забронировать место:1");
                Console.WriteLine("Проверить место:2");
                Console.WriteLine("Выйти:3");
                ask = Convert.ToInt32(Console.ReadLine());
                switch (ask)
                {
                    case 1:
                        {
                            Console.WriteLine("Выберите ряд:");
                            rr = Convert.ToInt32(Console.ReadLine());
                            rr--;
                            if (rr>(r-1) || rr<0 )
                            {
                                Console.WriteLine("Такого ряда нет, попробуйте ещё раз");
                                break;
                            }
                            Console.WriteLine("Выберите место:");
                            s = Convert.ToInt32(Console.ReadLine());
                            s--;
                            if( (s+1) > ryads[rr].Length || s<0)
                            {
                                Console.WriteLine("Такого места нет, попробуйте ещё раз");
                                break;
                            }
                            if(ryads[rr][s])
                            {
                                Console.WriteLine("Вы успешно забронировали место");
                                ryads[rr][s] = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Место уже занято");
                                break;
                            }

                        }
                    case 2:
                        {
                            Console.WriteLine("Выберите ряд:");
                            rr = Convert.ToInt32(Console.ReadLine());
                            rr--;
                            if (rr > (r-1) || rr < 0)
                            {
                                Console.WriteLine("Такого ряда нет, попробуйте ещё раз");
                                break;
                            }
                            Console.WriteLine("Выберите место:");
                            s = Convert.ToInt32(Console.ReadLine());
                            s--;
                            if ((s+1) > ryads[rr].Length || s < 0)
                            {
                                Console.WriteLine("Такого места нет, попробуйте ещё раз");
                                break;
                            }
                            if (ryads[rr][s])
                            {
                                Console.WriteLine("Место свободно");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Место занято");
                                break;
                            }
                        }
                    case 3:
                        {
                            Console.WriteLine("Удачного дня");
                            break;
                        }
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }
    }
}
