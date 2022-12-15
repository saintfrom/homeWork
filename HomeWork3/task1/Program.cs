using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №1
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Введенное число - четное");
            }
            else
                Console.WriteLine("Введенное число - нечетное");
        }
    }
}
