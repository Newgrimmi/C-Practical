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
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Введите 1, если хотите просмотреть данные");
                Console.WriteLine("Введите 2, если хотите внести данные");
                Console.WriteLine("Введите 3, если хотите выйти");
                string curNumb = Console.ReadLine();
                switch (curNumb)
                {
                    case "1":
                        ReadEmployeeInfo();
                        i--;
                        break;
                    case "2":
                        WriteEmployee();
                        i--;
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Введено не верное значение");
                        i--;
                        break;
                }
            }
        }

        static void WriteEmployee()
        {
            StringBuilder employeeInfo = new StringBuilder();

            if (File.Exists(@"e:\employeeData") == false)
            {
                employeeInfo.Append("1");
            }
            else
            {
                string[] employeeCount = File.ReadAllLines(@"e:\employeeData");
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

            File.AppendAllText(@"e:\employeeData", employeeInfo.ToString());
        }

        static void ReadEmployeeInfo()
        {
            string[] info = File.ReadAllLines(@"e:\employeeData");
            for (int i = 0; i < info.Length; i++)
            {
                Console.WriteLine($"{info[i]}");
            }
            Console.ReadKey();
        }
    }
}
