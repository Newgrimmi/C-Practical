using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("Приветствую, сколько карт у вас на руках?");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите номинал карты {i+1}");
                string inputString = Console.ReadLine();
                int parsedInputString;
                switch (inputString)
                {
                    case "J":
                        sum += 10;
                        break;
                    case "Q":
                        sum += 10;
                        break;
                    case "K":
                        sum += 10;
                        break;
                    case "T":
                        sum += 10;
                        break;
                    default:
                        if( int.TryParse(inputString, out parsedInputString) && parsedInputString < 11)
                        {
                            sum += parsedInputString;
                        }
                        else
                        {
                            Console.WriteLine("Не корректное значение карты, попробуйте ещё раз");
                            i--;
                        }
                        break;
                }
            }
            Console.WriteLine($"Сумма карт равна = {sum}");
            Console.ReadKey();
        }
    }
}
