using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            PrintText(SplitText(Console.ReadLine()));
        }
        static string[] SplitText(string text)
        {
            string[] splitedText = text.Split(' ');
            return splitedText;
        }
        static void PrintText(string[] splitedText)
        {
            foreach (string word in splitedText)
                Console.WriteLine($"Вывод каждого слова в отдельной строке: {word}");
        }
    }
}
