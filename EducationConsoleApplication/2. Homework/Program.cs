using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить массив длиной N случайнüми числами. Ввести с консоли число A.
            //Вывести Yes, если число A есть в массиве, No - в противном случае.
            Console.WriteLine("Количество элементов для массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] arraynumbers = new int[N];

            Random rand = new Random();

            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < N; i++)
            {
                arraynumbers[i] = rand.Next(10);
                Console.Write(i + 1 + ". ");
                Console.WriteLine(arraynumbers[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Введите число A для поиска его в массиве:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Такое число есть в массиве?");
            int FindA = Array.IndexOf(arraynumbers, A);
            if (FindA >= 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            //Заполнить матрицу NxM случайными числами. Из каждой строки
            //выбрать минимальный элемент, занести его в массив.
            //Отсортировать полученный массив и вывести его значения в обратном порядке.

            Console.WriteLine("Задать размерность матрицы NxM:");
            Console.Write("N=");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("M=");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix_NxM = new int[N, M];

            Random rand = new Random();

            Console.WriteLine("Заполненние матрицы NxM случайными числами:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix_NxM[i, j] = rand.Next(10);
                    Console.Write("{0}  ", matrix_NxM[i, j]);
                    //Console.Write((i + 1) + " строка " + (j + 1) + " столбец = ");
                    //Console.WriteLine(matrix_NxM[i, j]);
                }
                Console.WriteLine();
            }

            //Поиск минимального элемента в каждой строке
            int[] ArrayMinElement = new int[N];

            Console.WriteLine("Минимальный элемент каждой строки:\n");

            for (int i = 0; i < N; i++)
            {
                int MinElementInLine = matrix_NxM[i, 0];
                for (int j = 0; j < M; j++)
                {
                    if (matrix_NxM[i, j] < MinElementInLine)
                    {
                        MinElementInLine = matrix_NxM[i, j];
                    }
                }
                Console.WriteLine("Строка {0}, минимальный элемент: {1}", i+1, MinElementInLine);
                Console.WriteLine();

                ArrayMinElement[i] = MinElementInLine;

                //Вывод отсортированного по убыванию массива
                if (i+1 == N)
                {
                    Console.WriteLine("Вывод отсортированного по убыванию массива:");
                    Array.Sort(ArrayMinElement);
                    Array.Reverse(ArrayMinElement);
                    for (int k = 0; k < ArrayMinElement.Length; k++)
                    {
                        Console.Write(k + 1 + ". ");
                        Console.WriteLine(ArrayMinElement[k]);
                    }
                }
            }

            //Калькулятор. С консоли вводится левый операнд, операция, правый
            //операнд. Выводится результат операции над операндами.
            //Реализовать как минимум 4 операции, обработку ошибок (деление на ноль и др.)

            Console.WriteLine("Введите первый операнд:");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        RepeatChoiseOperation:
            Console.WriteLine("Введите операцию (+ сложение, - вычетание; * умножиние; / деление):");
            Char Operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            if (Operation != '+' & Operation != '-' & Operation != '*' & Operation != '/')
            {
                Console.WriteLine("Неподдерживаемая операция, выберите другую операцию");
                goto RepeatChoiseOperation;
            }

            Console.WriteLine("Введите второй операнд:");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (Operation == '/' & b == 0)
            {
                Console.WriteLine("Деление на ноль невозможно!\n");
                goto RepeatChoiseOperation;
            }

            if (Operation == '+')
            {
                Console.WriteLine("Результат суммы чисел:");
                Console.WriteLine(a + b);
            }

            if (Operation == '-')
            {
                Console.WriteLine("Результат разности чисел:");
                Console.WriteLine(a - b);
            }

            if (Operation == '*')
            {
                Console.WriteLine("Результат умножения чисел:");
                Console.WriteLine(a * b);
            }

            if (Operation == '/')
            {
                Console.WriteLine("Результат деления чисел:");
                Console.WriteLine(a / b);
            }
        }
    }
}
