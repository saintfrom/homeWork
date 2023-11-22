using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4t1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите количество строк");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int columns = int.Parse(Console.ReadLine());
            MatrixInit(rows, columns);

        }
        public static int[,] MatrixInit(int rows, int columns)
        {
            var matrix = new int[rows, columns];
            Random random = new Random();
            var summ = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next();
                    Console.Write($"{matrix[i, j]}" + "\t");
                    summ += matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма всех элементов матрицы = " + summ);
            return matrix;
        }
    }
}

