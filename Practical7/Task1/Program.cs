using System;
using System.IO;
using System.Text;

namespace Task1
{
    class Program
    {

        static void Main()
        {
            Worker newWorker = new Worker();
            Repository rep = new Repository();
            MainActive(newWorker, rep);
        }

        static void MainActive(Worker worker, Repository repository)
        {
            bool menuActive = true;
            while (menuActive)
            {
                Console.WriteLine("");
                Console.WriteLine("Введите 1, если хотите просмотреть данные");
                Console.WriteLine("Введите 2, если хотите внести данные");
                Console.WriteLine("Введите 3, если хотите выйти");
                Console.WriteLine("Введите 4, если хотите посмотреть данные по id");
                Console.WriteLine("Введите 5, если хотите удалить данные по id");
                Console.WriteLine("Введите 6, если хотите сортировать данные по датам");
                string curNumb = Console.ReadLine();
                switch (curNumb)
                {
                    case "1":
                        ReadEmployeeInfo(repository);
                        break;
                    case "2":
                        WriteEmployee(worker, repository);
                        break;
                    case "3":
                        menuActive = false;
                        break;
                    case "4":
                        Console.WriteLine("Введите id");
                        repository.GetWorkerById(int.Parse(Console.ReadLine())).PrintInfo();
                        break;
                    case "5":
                        Console.WriteLine("Введите id");
                        repository.DeleteWorker(int.Parse(Console.ReadLine()));
                        break;
                    case "6":
                        ReadEmployeeInfoToData(repository);
                        break;
                    default:
                        Console.WriteLine("Введено не верное значение");
                        break;
                }
            }
        }

        static void WriteEmployee(Worker worker, Repository repository)
        {

            worker.TimeToAdd = DateTime.Now;
            Console.WriteLine("Введите Ф.И.О.");
            worker.FIO = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            worker.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Рост");
            worker.Height = float.Parse(Console.ReadLine());
            Console.WriteLine("Дату рождения: дд.мм.гггг");
            worker.Birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите место рождения");
            worker.PlaceToBorn = Console.ReadLine();
            repository.AddWorker(worker);
        }

        static void ReadEmployeeInfo(Repository rep)
        {
            Worker[] allWorker = rep.GetAllWorkers();
            for (int i = 0; i < allWorker.Length; i++)
            {
                allWorker[i].PrintInfo();
            };
        }
        static void ReadEmployeeInfoToData(Repository rep)
        {
            Console.WriteLine("Введите первую дату");
            DateTime firstData = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую дату");
            DateTime secondData = DateTime.Parse(Console.ReadLine());
            Worker[] allWorker = rep.GetWorkersBetweenTwoDates(firstData, secondData);
            
            for (int i = 0; i < allWorker.Length; i++)
            {
                allWorker[i].PrintInfo();
            };
        }
    }
}



