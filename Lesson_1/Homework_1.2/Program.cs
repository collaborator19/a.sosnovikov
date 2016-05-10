using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с консоли 2 числа: n и i. Вывести значение i-ого бита числа n. 
            Console.Write("Введите число n для представления его в двоичной системе" + "\n" + "n=");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write(@"
n в двоичной системе:
" + (Convert.ToString(n, 2)) + @"

Введите число i для выбора номера бита числа n
(нумерация справа налево, начиная с нулевого бита:)
i=");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "Значение i-ого бита числа n:" + "\n" + ((n >> i) & 1));
        }
    }
}
