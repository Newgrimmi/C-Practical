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
            Console.WriteLine("Введите желаемое количество строк в матрице:");
            int line = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите желаемое количество столбцов в матрице:");
            int column = int.Parse(Console.ReadLine());
            int[,] matrixA = new int[line, column];
            int[,] matrixB = new int[line, column];
            int[,] matrixC = new int[line, column];
            Random rnd = new Random();

            Console.WriteLine("Матрица A:");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int y = 0; y < matrixA.GetLength(1); y++)
                {
                    matrixA[i, y] = rnd.Next(1, 15);
                    Console.Write($" {matrixA[i, y],2} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица В:");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int y = 0; y < matrixB.GetLength(1); y++)
                {
                    matrixB[i, y] = rnd.Next(1, 15);
                    Console.Write($" {matrixB[i, y],2} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма матриц:");
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int y = 0; y < matrixC.GetLength(1); y++)
                {
                    matrixC[i, y] = matrixA[i, y]+ matrixB[i, y];
                    Console.Write($" {matrixC[i, y],2} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
