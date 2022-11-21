using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            bool isCounter = false;
            Console.WriteLine("Введите проверяемое число:");
            int i = 2; //Если начинать с 1 как в вашем задании, всегда первое деление будет без остатка.
            int input =int.Parse(Console.ReadLine());
            while(i <= input - 1)
            {
                if(input % i == 0)
                {
                    isCounter = true;
                }
                i++;
            }
            if(isCounter == true)
            {
                Console.WriteLine("Число не является простым");
            }
            else 
            {
                Console.WriteLine("Число является простым");
            }
            Console.ReadKey();
        }
    }
}
