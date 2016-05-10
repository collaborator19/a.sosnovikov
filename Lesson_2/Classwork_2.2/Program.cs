using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить с консоли массив из N элементов. Отсортировать по возрастанию.
            //Вывести результат. N - задается с консоли.
            Console.WriteLine("Количество элементов для массива:");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arrayNumbers = new int[N];

            Console.WriteLine("\n" + "Вводимые элементы:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(i + 1 + ". ");
                int n = Convert.ToInt32(Console.ReadLine());
                arrayNumbers[i] = n;
            }

            //Сортировка массива
            Array.Sort(arrayNumbers);

            //Вывод результатов на экран
            Console.WriteLine("Вывод отсортированного по возрастанию массива:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(i + 1 + ". " + (arrayNumbers[i]) + "\n");
            }
        }
    }
}
