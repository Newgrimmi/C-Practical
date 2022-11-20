using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Быков Станислав Викторович";
            int age = 24;
            string eMail = "newgrimmi2@mail.ru";
            float informaticsScore = 95f;
            float mathScore = 54f;
            float physicsScore = 66f;

            string newPattern = "Ф.И.О.: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по информатике: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

            Console.WriteLine(newPattern,
                               fullName,
                               age,
                               eMail,
                               informaticsScore,
                               mathScore,
                               physicsScore);
            float sum;
            string averageScore; // без округления float averageScore

            sum = informaticsScore + mathScore + physicsScore;
            averageScore = (sum / 3).ToString("0.00"); //Чтобы округлить, если убрать то в 42 строке
            string newPattern2 = "Сумма баллов: {0} \nСреднеарифметическое: {1}";
            Console.WriteLine(newPattern2,
                               sum,
                               averageScore);
            Console.ReadKey();

            // float экономит место по сравнению с double и такая точность не нужно вроде...
        }
    }
}
