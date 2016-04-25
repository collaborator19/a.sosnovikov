using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Classwork
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значение,
            //количество четных чисел, произведение нечетных чисел..
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;

            Console.WriteLine("Количество чисел для введения с консоли:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Вводимые числа:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(i + 1 + ". ");
                int n = Convert.ToInt32(Console.ReadLine());

                //Сумма этих чисел
                a1 = a1 + n;

                //Максимальное значение среди этих чисел
                if (a2 == 0)
                {
                    a2 = n;
                }
                if (n > a2)
                {
                    a2 = n;
                }

                //Минимальное значение среди этих чисел
                if (a3 == 0)
                {
                    a3 = n;
                }
                if (n < a3)
                {
                    a3 = n;
                }

                //количество четных чисел
                if (n % 2 == 0)
                {
                    a4++;
                }

                //Произведение нечетных чисел
                if (n % 2 == 1)
                {
                    if (a5 == 0)
                    {
                        a5 = n;
                    }
                    if (a5 != n)
                    {
                       a5 = a5 * n;
                    }
                }

                //Вывод результатов на экран
                if (i+1 == N)
                {
                    Console.WriteLine("Сумма этих чисел:");
                    Console.WriteLine(a1);

                    Console.WriteLine("Максимальное значение среди этих чисел:");
                    Console.WriteLine(a2);

                    Console.WriteLine("Минимальное значение среди этих чисел:");
                    Console.WriteLine(a3);

                    Console.WriteLine("Количество четных чисел:");
                    Console.WriteLine(a4);

                    Console.WriteLine("Произведение нечетных чисел:");
                    Console.WriteLine(a5);
                }
            }
            
            //Заполнить с консоли массив из N элементов. Отсортировать по возрастанию.
            //Вывести результат. N - задается с консоли.

            Console.WriteLine("Количество элементов для массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] numbers = new int[N];

            Console.WriteLine("Вводимые элементы:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(i + 1 + ". ");
                int n = Convert.ToInt32(Console.ReadLine());
                numbers[i] = n;
            }

            Array.Sort(numbers);

            Console.WriteLine("Вывод отсортированного по возрастанию массива:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(numbers[i]);
            }

            //Заполнить 2 матрицы размерности NxN случайными числами.
            //Вывести на консоль. Сложить 2 матрицы. Вывести результат.
            Console.WriteLine("Задать размерность матриц NxN:");
            Console.Write("N=");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int [,] matrix1_NxN = new int[N, N];
            int [,] matrix2_NxN = new int[N, N];
            int [,] matrix_sum = new int[N, N];

            Random rand = new Random();

            Console.WriteLine("Первая матрица, заполненная случайными числами:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix1_NxN[i, j] = rand.Next(10);
                    Console.Write((i + 1) + " строка " + (j + 1) + " столбец = ");
                    Console.WriteLine(matrix1_NxN[i, j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Вторая матрица, заполненная случайными числами:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix2_NxN[i, j] = rand.Next(10);
                    Console.Write((i + 1) + " строка " + (j + 1) + " столбец = ");
                    Console.WriteLine(matrix2_NxN[i, j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Сложение двух матриц:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix_sum[i, j] = matrix1_NxN[i, j] + matrix2_NxN[i, j];
                    Console.Write((i + 1) + " строка " + (j + 1) + " столбец = ");
                    Console.WriteLine(matrix_sum[i, j]);
                }
            }
        }
    }
}
