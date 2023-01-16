using System;
using System.IO;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            MainActive(); 
        }

        static void MainActive()
        {
            bool menuActive = true;
            while (menuActive)
            {
                Console.WriteLine("Введите 1, если хотите просмотреть данные");
                Console.WriteLine("Введите 2, если хотите внести данные");
                Console.WriteLine("Введите 3, если хотите выйти");
                string curNumb = Console.ReadLine();
                switch (curNumb)
                {
                    case "1":
                        ReadEmployeeInfo();
                        break;
                    case "2":
                        WriteEmployee();
                        break;
                    case "3":
                        menuActive = false;
                        break;
                    default:
                        Console.WriteLine("Введено не верное значение");
                        break;
                }
            }
        }

        static void WriteEmployee()
        {
            StringBuilder employeeInfo = new StringBuilder();

            if (File.Exists("employeeData.txt") == false)
            {
                employeeInfo.Append("1");
            }
            else
            {
                string[] employeeCount = File.ReadAllLines("employeeData.txt");
                employeeInfo.Append("\n" + (employeeCount.Length + 1));
            }

            Console.WriteLine("Введите дату и время добавления записи: дд.мм.гггг чч:мм");
            employeeInfo.Append(" " + Console.ReadLine());
            Console.WriteLine("Введите Ф.И.О.");
            employeeInfo.Append(" " + Console.ReadLine());
            Console.WriteLine("Введите возраст");
            employeeInfo.Append(" " + Console.ReadLine());
            Console.WriteLine("Рост");
            employeeInfo.Append(" " + Console.ReadLine());
            Console.WriteLine("Дату рождения: дд.мм.гггг");
            employeeInfo.Append(" " + Console.ReadLine());
            Console.WriteLine("Введите место рождения");
            employeeInfo.Append(" " + "город:" + Console.ReadLine());

            File.AppendAllText("employeeData.txt", employeeInfo.ToString());
        }

        static void ReadEmployeeInfo()
        {
            if (File.Exists("employeeData.txt") == false)
            {
                WriteEmployee();
            }
            else
            {
                string[] info = File.ReadAllLines("employeeData.txt");
                for (int i = 0; i < info.Length; i++)
                {
                    Console.WriteLine($"{info[i]}");
                }
                Console.ReadKey();
            }
            
        }
    }
}
