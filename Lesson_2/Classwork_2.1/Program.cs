using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значение,
            //количество четных чисел, произведение нечетных чисел.
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;

            Console.WriteLine("Количество чисел для введения с консоли:");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "Вводимые числа:");
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
                if (i + 1 == N)
                {
                    Console.WriteLine("\n" + "Сумма этих чисел:" + "\n" + (a1) + "\n");
                    Console.WriteLine("Максимальное значение среди этих чисел:" + "\n" + (a2) + "\n");
                    Console.WriteLine("Минимальное значение среди этих чисел:" + "\n" + (a3) + "\n");
                    Console.WriteLine("Количество четных чисел:" + "\n" + (a4) + "\n");
                    Console.WriteLine("Произведение нечетных чисел:" + (a5));
                }
            }
        }
    }
}
