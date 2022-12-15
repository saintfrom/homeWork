using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Задание №4
            Console.WriteLine("Введите длину последовательности");
            int orderLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Последовательно вводите целые числа");
            int minValue = int.MaxValue;
            for (int k = 0; k < orderLength; k++)
            {
                int enteredNumber = int.Parse(Console.ReadLine());
                if (enteredNumber < minValue)
                {
                    minValue = enteredNumber;
                }
            }
            Console.WriteLine($"Наименьшее число {minValue}");
        }
    }
}
