using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить массив длиной N случайнüми числами. Ввести с консоли число A.
            //Вывести Yes, если число A есть в массиве, No - в противном случае.
            Console.WriteLine("Количество элементов для массива:");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arrayNumbers = new int[N];

            Random rand = new Random();

            Console.WriteLine("\n" + "Элементы массива:");
            for (int i = 0; i < N; i++)
            {
                arrayNumbers[i] = rand.Next(10);
                Console.Write(i + 1 + ". " + (arrayNumbers[i]) + "\n");
            }

            Console.WriteLine("\n" + "Введите число A для поиска его в массиве:");
            int A = Convert.ToInt32(Console.ReadLine());

            //Поиск в массиве
            Console.WriteLine("\n" + "Такое число есть в массиве?");
            int FindA = Array.IndexOf(arrayNumbers, A);
            if (FindA >= 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
