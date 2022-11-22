using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    namespace GameOfLife
    {

        public class LifeSimulation
        {
            private int _heigth;
            private int _width;
            private bool[,] cells;

            public LifeSimulation(int Heigth, int Width)
            {
                _heigth = Heigth;
                _width = Width;
                cells = new bool[Heigth, Width];
                GenerateField();
            }

            public void DrawAndGrow()
            {
                DrawGame();
                Grow();
            }

            private void Grow()
            {
                for (int i = 0; i < _heigth; i++)
                {
                    for (int j = 0; j < _width; j++)
                    {
                        int numOfAliveNeighbors = GetNeighbors(i, j);

                        if (cells[i, j])
                        {
                            if (numOfAliveNeighbors < 2)
                            {
                                cells[i, j] = false;
                            }

                            if (numOfAliveNeighbors > 3)
                            {
                                cells[i, j] = false;
                            }
                        }
                        else
                        {
                            if (numOfAliveNeighbors == 3)
                            {
                                cells[i, j] = true;
                            }
                        }
                    }
                }
            }

            private int GetNeighbors(int x, int y)
            {
                int NumOfAliveNeighbors = 0;

                for (int i = x - 2; i < x + 3; i++)
                {
                    for (int j = y - 2; j < y + 3; j++)
                    {
                        if (!((i < 1 || j < 1) || (i >= _heigth || j >= _width)))
                        {
                            if (cells[i, j] == true) NumOfAliveNeighbors++;
                        }
                    }
                }
                return NumOfAliveNeighbors;
            }

            private void DrawGame()
            {
                for (int i = 0; i < _heigth; i++)
                {
                    for (int j = 0; j < _width; j++)
                    {
                        Console.Write(cells[i, j] ? "x" : " ");
                        if (j == _width - 1) Console.WriteLine("\r");
                    }
                }
                Console.SetCursorPosition(0, Console.WindowTop);
            }

            private void GenerateField()
            {
                Random generator = new Random();
                int number;
                for (int i = 0; i < _heigth; i++)
                {
                    for (int j = 0; j < _width; j++)
                    {
                        number = generator.Next(3);
                        cells[i, j] = ((number == 0) ? false : true);
                    }
                }
            }
        }

        internal class Program
        {

            // Ограничения игры
            private const int Heigth = 20;
            private const int Width = 30;
            private const uint MaxRuns = 100;

            private static void Main()
            {
                int runs = 0;
                LifeSimulation sim = new LifeSimulation(Heigth, Width);

                while (runs++ < MaxRuns)
                {
                    sim.DrawAndGrow();

                    System.Threading.Thread.Sleep(200);
                }
            }
        }
    }

}
