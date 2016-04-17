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
            //количество четных чисел, произведение нечетных чисел.
            Console.WriteLine("Количество чисел для введения с консоли:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Вводимые числа:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(i+1 + ". ");
                Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Сумма этих чисел:");
            Console.WriteLine();
        }
    }
}
