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
            Console.WriteLine("Напишите предложение");
            string sentence = Console.ReadLine();

            Reverse(SplitText(sentence));
        }

        //Считает сколько слов в предложении, чтобы дальше создать массив такой длины
        public static int CountWords(char[] let)
        {
            int countWord = 1;
            char[] letters = new char[let.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = let[i];

                if (letters[i] == ' ')
                {
                    countWord++;
                }
            }
            return countWord;
        }

        //Разделяет полученный текст на массив слов
        public static string[] SplitText(string text)
        {
            char[] letters = text.ToCharArray();
            int countWords = CountWords(letters);
            string[] words = new string[countWords];
            int numberWord = 0;
            string word = "";

            for (int i = 0; i < letters.Length; i++)
            {

                if (i == letters.Length - 1)
                {
                    word += letters[i];
                    words[numberWord] = word;
                }
                else if (letters[i] != ' ')
                {
                    word += letters[i];
                }
                else
                {
                    words[numberWord] = word;
                    numberWord++;
                    word = "";
                }
            }

            return words;
        }

        //Меняет местами слова в массиве и конвертирует их в строчку
        public static string Reverse(string[] text)
        {
            int firstWord = 0;
            int lastWord = text.Length-1;
            string average;
            string reverseText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (firstWord < lastWord)
                {
                    average = text[firstWord];
                    text[firstWord] = text[lastWord];
                    text[lastWord] = average;
                }
                firstWord++;
                lastWord--;
            }

            for (int i = 0; i < text.Length; i++)
            {
                reverseText += text[i] + " ";
            }
            Console.WriteLine($"{reverseText}");
            Console.ReadKey();

            return reverseText;
        }
    }
}
