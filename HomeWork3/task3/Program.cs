using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Задание №3
            Console.WriteLine("Введите число для проверки: ");
            int checkNumber = int.Parse(Console.ReadLine());
            bool isPrime = false;
            int i = 1;
            while (i < checkNumber - 1)
            {
                i++;
                int result = checkNumber % i;
                if (result == 0)
                {
                    isPrime = true;
                    break;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine("Число не простое");
            }
            else Console.WriteLine("Число простое");
        }
    }
}
