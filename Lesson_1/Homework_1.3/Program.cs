using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль.
            Console.Write("Введите число для представления его в двоичной системе:" + "\n");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "Это в двоичной системе:" + "\n" + (Convert.ToString(number, 2)));

            Console.WriteLine("\n" + "После обнуления последнего бита в двоичной системе получается:");
            number = number >> 1;
            number = number << 1;

            Console.WriteLine(Convert.ToString(number, 2) + "\n\n" + "И это получается число:" + "\n" + (number));
        }
    }
}
