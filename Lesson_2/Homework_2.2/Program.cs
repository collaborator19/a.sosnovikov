using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить матрицу NxM случайными числами. Из каждой строки
            //выбрать минимальный элемент, занести его в массив.
            //Отсортировать полученный массив и вывести его значения в обратном порядке.
            Console.Write("Задать размерность матрицы NxM:" + "\n" + "N=");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + "M=");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] matrixNxM = new int[N, M];

            Random rand = new Random();

            Console.WriteLine("\n" + "Заполненние матрицы NxM случайными числами:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrixNxM[i, j] = rand.Next(10);
                    Console.Write(matrixNxM[i, j] + "  ");
                }
                Console.WriteLine();
            }

            //Поиск минимального элемента в каждой строке
            int[] arrayMinElement = new int[N];

            Console.WriteLine("\n" + "Минимальный элемент каждой строки:");
            for (int i = 0; i < N; i++)
            {
                int minElementInLine = matrixNxM[i, 0];
                for (int j = 0; j < M; j++)
                {
                    if (matrixNxM[i, j] < minElementInLine)
                    {
                        minElementInLine = matrixNxM[i, j];
                    }
                }
                Console.WriteLine("В строке " + (i + 1) + " минимальный элемент: " + minElementInLine);

                arrayMinElement[i] = minElementInLine;
            }

            //Вывод отсортированного по убыванию массива
            Console.WriteLine("\n" + "Вывод отсортированного по убыванию массива:");
            Array.Sort(arrayMinElement);
            Array.Reverse(arrayMinElement);
            for (int k = 0; k < arrayMinElement.Length; k++)
            {
                Console.Write(k + 1 + ". ");
                Console.WriteLine(arrayMinElement[k]);
            }
        }
    }
}
