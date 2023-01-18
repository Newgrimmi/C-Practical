using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Task1
{
    public class Repository
    {
        private int index = 1;

        public Worker[] GetAllWorkers()
        {
            // здесь происходит чтение из файла
            // и возврат массива считанных экземпляров
            string[] info = File.ReadAllLines("employeeData.txt");
            Worker[] readWorker = new Worker[info.Length];

            for (int i = 0; i < info.Length; i++)
            {
                string[] arg = info[i].Split(',');
                readWorker[i] = new Worker(int.Parse(arg[0]), DateTime.Parse(arg[1]), arg[2], int.Parse(arg[3]), float.Parse(arg[4]), DateTime.Parse(arg[5]), arg[6]);
            }

            return readWorker;
        }

        public Worker GetWorkerById(int id)
        {
            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID
            string[] info = File.ReadAllLines("employeeData.txt");
            Worker readWorker = new Worker();

            for (int i = 0; i < info.Length; i++)
            {
                string[] arg = info[i].Split(',');
                if (int.Parse(arg[0]) == id)
                {
                    readWorker = new Worker(int.Parse(arg[0]), DateTime.Parse(arg[1]), arg[2], int.Parse(arg[3]), float.Parse(arg[4]), DateTime.Parse(arg[5]), arg[6]);
                    break;
                }
            }

            return readWorker;
        }

        public void DeleteWorker(int id)
        {
            // считывается файл, находится нужный Worker
            // происходит запись в файл всех Worker,
            // кроме удаляемого

            string[] info = File.ReadAllLines("employeeData.txt");
            Worker[] readWorker = new Worker[info.Length];

            for (int i = 0; i < info.Length; i++)
            {
                string[] arg = info[i].Split(',');
                readWorker[i] = new Worker(int.Parse(arg[0]), DateTime.Parse(arg[1]), arg[2], int.Parse(arg[3]), float.Parse(arg[4]), DateTime.Parse(arg[5]), arg[6]);
            }

            File.Delete("employeeData.txt");
            StringBuilder employeeInfo = new StringBuilder();

            for (int i = 0; i < readWorker.Length; i++)
            {
                if (readWorker[i].Id == id)
                {
                    continue;
                }
                employeeInfo.Append($"{readWorker[i].Id}, {readWorker[i].TimeToAdd}, {readWorker[i].FIO}, {readWorker[i].Age}, {readWorker[i].Height}, {readWorker[i].Birthday}, {readWorker[i].PlaceToBorn} \n");
            }

            File.AppendAllText("employeeData.txt", employeeInfo.ToString());
        }

        public void AddWorker(Worker worker)
        {
            // присваиваем worker уникальный ID,
            // дописываем нового worker в файл

            if (File.Exists("employeeData.txt"))
            {
                string[] info = File.ReadAllLines("employeeData.txt");
                index = info.Length + 1;
            }

            worker.Id = index;
            StringBuilder employeeInfo = new StringBuilder();
            employeeInfo.Append($"{worker.Id}, {worker.TimeToAdd}, {worker.FIO}, {worker.Age}, {worker.Height}, {worker.Birthday}, {worker.PlaceToBorn} \n");
            File.AppendAllText("employeeData.txt", employeeInfo.ToString());
            index++;
        }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            // здесь происходит чтение из файла
            // фильтрация нужных записей
            // и возврат массива считанных экземпляров
            Worker[] readWorker;
            string[] info = File.ReadAllLines("employeeData.txt");
            int countWorker = 0;
            List<Worker> worker = new List<Worker>();

            for (int i = 0; i < info.Length; i++)
            {
                string[] arg = info[i].Split(',');
                if (dateFrom < DateTime.Parse(arg[1]) && DateTime.Parse(arg[1]) < dateTo)
                {
                    countWorker++;
                    worker.Add(new Worker(int.Parse(arg[0]), DateTime.Parse(arg[1]), arg[2], int.Parse(arg[3]), float.Parse(arg[4]), DateTime.Parse(arg[5]), arg[6]));
                }
            }

            readWorker = worker.ToArray();
            return readWorker;
        }

        public Worker[] SortWorkersToId()
        {
            Console.WriteLine("Введите 0, если по возрастанию, 1 если по убыванию");
            int upDown = int.Parse(Console.ReadLine());
            string[] info = File.ReadAllLines("employeeData.txt");
            Worker[] readWorker = new Worker[info.Length];
            List<Worker> worker = new List<Worker>();

            for (int i = 0; i < info.Length; i++)
            {
                string[] arg = info[i].Split(',');
                readWorker[i] = new Worker(int.Parse(arg[0]), DateTime.Parse(arg[1]), arg[2], int.Parse(arg[3]), float.Parse(arg[4]), DateTime.Parse(arg[5]), arg[6]);
            }

            if (upDown == 0)
            {
                worker.AddRange(readWorker.OrderBy(w => w.Id));
                return worker.ToArray();
            }   
            else if (upDown == 1)
            {

                worker.AddRange(readWorker.OrderByDescending(w => w.Id));
                return worker.ToArray();
            }
                
            return readWorker;
        }

        public Worker[] SortWorkersToAge()
        {
            Console.WriteLine("Введите 0, если по возрастанию, 1 если по убыванию");
            int upDown = int.Parse(Console.ReadLine());
            string[] info = File.ReadAllLines("employeeData.txt");
            Worker[] readWorker = new Worker[info.Length];
            List<Worker> worker = new List<Worker>();

            for (int i = 0; i < info.Length; i++)
            {
                string[] arg = info[i].Split(',');
                readWorker[i] = new Worker(int.Parse(arg[0]), DateTime.Parse(arg[1]), arg[2], int.Parse(arg[3]), float.Parse(arg[4]), DateTime.Parse(arg[5]), arg[6]);
            }

            if (upDown == 0)
            {
                worker.AddRange(readWorker.OrderBy(w => w.Age));
                return worker.ToArray();
            }
            else if (upDown == 1)
            {
                worker.AddRange(readWorker.OrderByDescending(w => w.Age));
                return worker.ToArray();
            };

            return readWorker;
        }

        public Worker[] SortWorkersToFIO()
        {
            Console.WriteLine("Введите 0, если по возрастанию, 1 если по убыванию");
            int upDown = int.Parse(Console.ReadLine());
            string[] info = File.ReadAllLines("employeeData.txt");
            Worker[] readWorker = new Worker[info.Length];
            List<Worker> worker = new List<Worker>();

            for (int i = 0; i < info.Length; i++)
            {
                string[] arg = info[i].Split(',');
                readWorker[i] = new Worker(int.Parse(arg[0]), DateTime.Parse(arg[1]), arg[2], int.Parse(arg[3]), float.Parse(arg[4]), DateTime.Parse(arg[5]), arg[6]);
            }

            if (upDown == 0)
            {
                worker.AddRange(readWorker.OrderBy(w => w.FIO));
                return worker.ToArray();
            }
            else if (upDown == 1)
            {
                worker.AddRange(readWorker.OrderByDescending(w => w.FIO));
                return worker.ToArray();
            };

            return readWorker;
        }
    }
}



