using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы №1");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы №1");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] matrix1 = MatrixInit(rows, columns);
            Console.WriteLine("Введите количество строк матрицы №2");
            int rows2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы №2");
            int columns2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] matrix2 = MatrixInit(rows2, columns2);
            if (rows != rows2 || columns != columns2)
            {
                Console.WriteLine("Нельзя складывать матрицы с разной размерностью");
            }
            else
            {
                Console.WriteLine("Результат сложения матриц");
                var matrix = new int[rows, columns2];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns2; j++)
                    {
                        matrix[i, j] = matrix1[i, j] + matrix2[i, j];
                        Console.Write($"{matrix[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadKey();
        }
        public static int[,] MatrixInit(int rows, int columns)
        {
            var matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(10);
                    Console.Write($"{matrix[i, j]}" + "\t");
                }
                Console.WriteLine();
            }

            return matrix;
        }
    }
}

