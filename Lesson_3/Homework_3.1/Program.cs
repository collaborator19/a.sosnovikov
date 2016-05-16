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
            //символ строки, а значением - количество ЭТИХ символов в
            //считанной строке.
            Console.WriteLine("Введите строку с консоли:");
            string stringFromConsole = Console.ReadLine();

            Console.WriteLine("\n" + "Длина строки:" + "\n" + stringFromConsole.Length + "\n");

            Dictionary<char, int> dictionaryStringFromConsole = new Dictionary<char, int>();

            for (int i = 0; i < stringFromConsole.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < stringFromConsole.Length; j++)
                {
                    if (stringFromConsole[i] == stringFromConsole[j])
                    {
                        counter++;
                    }
                }
                //Пришлось сделать вывод только уникального ключа, поскольку он повторяется
                //и даёт ошибку на неуникальность, если >1 одинакового символа.
                if (!dictionaryStringFromConsole.ContainsKey(stringFromConsole[i]))
                {
                    dictionaryStringFromConsole.Add(stringFromConsole[i], counter);
                }
            }

            //Вывод словаря
            foreach (KeyValuePair<char, int>KeyValuePair in dictionaryStringFromConsole)
            {
                Console.WriteLine("Ключ: " + KeyValuePair.Key + " Значение: " + KeyValuePair.Value);
            }
        }
    }
}
