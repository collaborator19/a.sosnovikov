using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Считать строку с консоли. Создать словарь, где ключом будет
            //символ строки, а значением - количество данных символов в
            //считанной строке.
            Console.WriteLine("Введите строку с консоли:");
            string stringFromConsole = Console.ReadLine();

            int lenghtStringFromConsole = stringFromConsole.Length;
            Console.WriteLine("\n" + "Длина строки:" + "\n" + lenghtStringFromConsole + "\n");

            for (int i = 0; i < lenghtStringFromConsole; i++)
            {
                Dictionary<char, int> dictionaryStringFromConsole = new Dictionary<char, int>();
                dictionaryStringFromConsole.Add(stringFromConsole[i], lenghtStringFromConsole);

                Console.WriteLine("Ключ: " + stringFromConsole[i] + " Значение: " + dictionaryStringFromConsole[stringFromConsole[i]]);
            }
        }
    }
}
