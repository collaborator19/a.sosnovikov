using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        //Сделать методы для считывания целых чисел, дробных чисел.
        //Сделать методы для вывода на консоль этих типов данных,
        //массивов целых и дробных чисел

        private static int GetInt()
        {
            Console.WriteLine("Введите целое число:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a1);
            return a1;
        }
    }
}
