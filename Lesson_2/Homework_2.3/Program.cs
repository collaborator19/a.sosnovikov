using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Калькулятор. С консоли вводится левый операнд, операция, правый
            //операнд. Выводится результат операции над операндами.
            //Реализовать как минимум 4 операции, обработку ошибок (деление на ноль и др.)

            Console.WriteLine("Введите первый операнд:");
            float operand1 = Convert.ToInt32(Console.ReadLine());

        RepeatChoiseOperation:
            Console.WriteLine("\n" + "Введите операцию (+ сложение, - вычетание; * умножиние; / деление):");
            Char operation = Convert.ToChar(Console.ReadLine());

            if (operation != '+' & operation != '-' & operation != '*' & operation != '/')
            {
                Console.WriteLine("\n" + "Неподдерживаемая операция, выберите другую операцию!");
                goto RepeatChoiseOperation;
            }

            Console.WriteLine("\n" + "Введите второй операнд:");
            float operand2 = Convert.ToInt32(Console.ReadLine());

            //Обработка ошибки "деление на ноль"
            if (operation == '/' & operand2 == 0)
            {
                Console.WriteLine("\n" + "Деление на ноль невозможно!" + "\n");
                goto RepeatChoiseOperation;
            }

            if (operation == '+')
            {
                Console.WriteLine("\n" + "Результат суммы чисел:" + "\n" + (operand1 + operand2));
            }

            if (operation == '-')
            {
                Console.WriteLine("\n" + "Результат разности чисел:" + "\n" + (operand1 - operand2));
            }

            if (operation == '*')
            {
                Console.WriteLine("\n" + "Результат умножения чисел:" + "\n" + (operand1 * operand2));
            }

            if (operation == '/')
            {
                Console.WriteLine("\n" + "Результат деления чисел:" + "\n" + (operand1 / operand2));
            }
        }
    }
}
