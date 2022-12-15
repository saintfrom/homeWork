using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №5
            Console.WriteLine("Введите максимальное целое число диапазона");
            int resultRandom = RandomNumber();
            Console.WriteLine("Попробуйте отгадать число");
            while (true)
            {
                Console.WriteLine("Введите число");
                string line = CheckingEmptyLines();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }
                else
                {
                    int userNumber = int.Parse(line);
                    if (userNumber > resultRandom)
                    {
                        Console.WriteLine("Введенное число больше загаданного");
                    }
                    else if (userNumber < resultRandom)
                    {
                        Console.WriteLine("Введенное число меньше загаданного");
                    }
                    else if (userNumber == resultRandom)
                    {
                        Console.WriteLine("Вы угадали. Введите новое число диапазона");
                        if (string.IsNullOrEmpty(line))
                        {
                            break;
                        }
                        else
                            Console.WriteLine("Начинаем новый цикл");
                    }
                }

            }
            int RandomNumber()
            {
                int rangeLength = int.Parse(Console.ReadLine());
                Random random = new Random();
                int randomNumber = random.Next(0, rangeLength + 1);
                return randomNumber;
            }
            string CheckingEmptyLines()
            {
                string line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    Console.WriteLine("Загаданное число: " + resultRandom);
                }
                return line;
            }
        }
    }
}
