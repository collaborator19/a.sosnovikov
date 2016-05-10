using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить 2 матрицы размерности NxN случайными числами.
            //Вывести на консоль. Сложить 2 матрицы. Вывести результат.
            Console.Write("Задать размерность матриц NxN:" + "\n" + "N=");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1NxN = new int[N, N];
            int[,] matrix2NxN = new int[N, N];
            int[,] matrixSum = new int[N, N];

            Random rand = new Random();

            //Заполнение первой матрицы
            Console.WriteLine("\n" + "Первая матрица, заполненная случайными числами:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix1NxN[i, j] = rand.Next(10);
                    //Console.Write((i + 1) + " строка " + (j + 1) + " столбец = " + (matrix1NxN[i, j]) + "\n");
                    Console.Write((matrix1NxN[i, j]) + "  ");
                }
                Console.WriteLine();
            }

            //Заполнение второй матрицы
            Console.WriteLine("\n" + "Вторая матрица, заполненная случайными числами:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix2NxN[i, j] = rand.Next(10);
                    Console.Write((matrix2NxN[i, j]) + "  ");
                }
                Console.WriteLine();
            }

            //Сложение двух матриц
            Console.WriteLine("\n" + "Сложение двух матриц:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrixSum[i, j] = matrix1NxN[i, j] + matrix2NxN[i, j];
                    //Console.Write((i + 1) + " строка " + (j + 1) + " столбец = " + (matrixSum[i, j]) + "\n");
                    Console.Write(matrixSum[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
