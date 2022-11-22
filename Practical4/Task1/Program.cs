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
            Console.WriteLine("Введите желаемое количество строк в матрице:");
            int line = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите желаемое количество столбцов в матрице:");
            int column = int.Parse(Console.ReadLine());
            int[,] matrix = new int [line, column];

            int sum = 0;
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    matrix[i, y] = rnd.Next(1, 15);
                    Console.Write($" {matrix[i, y] , 2} ");
                    sum += matrix[i, y];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nСумма всех элементов матрицы: {sum}");
            Console.ReadKey();
        }
    }
}
