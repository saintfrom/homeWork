using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №2
            Console.WriteLine("Приветствую, сколько карт?");
            int cardHold = int.Parse(Console.ReadLine());
            Console.WriteLine("Вводите карты по очереди");
            int sumCard = 0;
            for (int j = 0; j < cardHold; j++)
            {
                Console.WriteLine("Введите номинал следующей карты");
                var cardNum = Console.ReadLine();
                switch (cardNum)
                {
                    case "K":
                        sumCard = sumCard + 10;
                        break;
                    case "Q":
                        sumCard = sumCard + 10;
                        break;
                    case "J":
                        sumCard = sumCard + 10;
                        break;
                    case "T":
                        sumCard = sumCard + 10;
                        break;

                    default:
                        sumCard = sumCard + int.Parse(cardNum);
                        break;
                }

            }
            Console.WriteLine("Сумма карт на руках: " + sumCard);
        }
    }
}
