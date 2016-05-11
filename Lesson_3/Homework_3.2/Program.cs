using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Считывать с консоли числа, пока не будет введено число “-1”, среди
            //введенных чисел вывести все дублирующиеся.
            int injectedNumbers = 1;
            List<int> integersAll = new List<int>();
            List<int> integersDuplicate = new List<int>();

            Console.WriteLine("Введите числа с консоли с нажатием Enter после каждого введённого числа:");

            for (int i = 0; i < injectedNumbers; i++)
            {
                int integerFromConsole = Convert.ToInt32(Console.ReadLine());

                if (integersAll.Contains(integerFromConsole))
                {
                    integersDuplicate.Add(integerFromConsole);
                }
                else
                {
                    integersAll.Add(integerFromConsole);
                }

                if (integerFromConsole != -1)
                {
                    injectedNumbers++;
                }
                else
                {
                    if (integersDuplicate.Count == 0)
                    {
                        Console.WriteLine("Повторяющихся чисел среди введённых нет.");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "Дублируются следующие введёные числа:");
                        for (int j = 0; j < integersDuplicate.Count; j++)
                        {
                            Console.WriteLine(integersDuplicate[j]);
                        }
                    }
                }
            }
        }
    }
}
