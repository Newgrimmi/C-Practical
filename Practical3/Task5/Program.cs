﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введи максимальное число:");
            int maxValue = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int range = rnd.Next(0, maxValue + 1);
            for(; ; )
            {
                Console.WriteLine("\nВведите число:");
                int inputValue = int.Parse(Console.ReadLine());
                if(inputValue < range)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else if (inputValue > range)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                else
                {
                    Console.WriteLine($"Вы угадали, загаданное число {range}");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
