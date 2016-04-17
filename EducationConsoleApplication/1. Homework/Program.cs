using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с консоли 2 числа. Вывести их сумму на консоль.

            Console.WriteLine("Введите первое число для сложения:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для сложения:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Их сумма:");
            Console.WriteLine(a1 + b1);

            //Ввести с консоли 2 числа: n и i. Вывести значение i-ого бита числа n. 
            Console.WriteLine("Введите число n для представления его в двоичной системе");
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("n в двоичной системе:");
            Console.WriteLine(Convert.ToString(n, 2));
            Console.WriteLine();

            Console.WriteLine("Введите число i для выбора номера бита числа n (нумерация справа налево, начиная с нулевого бита)");
            Console.Write("i=");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Значение i-ого бита числа n:");
            System.Console.WriteLine((n>>i)&1);

            //Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль.
            Console.WriteLine("Введите a3 число для представления его в двоичной системе");
            Console.Write("a3=");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("a3 в двоичной системе:");
            Console.WriteLine(Convert.ToString(a3, 2));
            Console.WriteLine();

            Console.WriteLine("После обнуления последнего бита в двоичной системе получается:");
            System.Console.WriteLine(Convert.ToString(a3 >> 1, 2));
            Console.WriteLine();

            Console.WriteLine("И это получается число:");
            System.Console.WriteLine(a3 >> 1);
        }
    }
}
