using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с консоли 2 числа. Вывести их сумму на консоль.
            Console.WriteLine("Введите первое число для сложения:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите второе число для сложения:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nИх сумма:\n" + (number1 + number2));
        }
    }
}
