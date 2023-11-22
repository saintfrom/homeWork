using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для преобразования: ");
            RewerseWords(Console.ReadLine());
        }
        static void RewerseWords (string inputPhrase)
        {
            string endPhrase = Reverse(inputPhrase);
            Console.WriteLine($"Преобразованный текст: {endPhrase}");
        }
        static string[] SplitText(string text)
        {
            string[] splitedText = text.Split(' ');
            return splitedText;
        }
        static string Reverse(string text)
        {
            string[] splitedText = SplitText(text);
            List<string> reversedText = new List<string>();
            foreach (string word in splitedText)
                reversedText.Add(word);
            reversedText.Reverse();
            string reversedPhrase = String.Join(" ", reversedText);
            return reversedPhrase;
        }
    }
}
