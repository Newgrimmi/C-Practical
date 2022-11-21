using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        
        static void Main()
        {
            int input;
            Console.WriteLine("Введите целое число");
            input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("Данное число является четным");
            }
            else
            {
                Console.WriteLine("Данное число является нечетным");
            }
            Console.ReadKey();
        }
    }
}
