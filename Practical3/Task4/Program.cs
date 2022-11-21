using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            int minValue = int.MaxValue;
            Console.WriteLine("Введите длину последовательности");
            int lenghtCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < lenghtCount; i++)
            {
                Console.WriteLine($"Введите число {i+1}");
                int curValue = int.Parse(Console.ReadLine());
                if (curValue < minValue)
                {
                    minValue = curValue;
                }
            }
            Console.WriteLine($"Минимальное число из последовательности {minValue}");
            Console.ReadKey();
        }
    }
}
