using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_4._2
{
    //Создать класс “Телефон”, который содержит следующие данные: код
    //города, номер телефона, которые не могут быть изменены. Добавить
    //метод, который возвращает строку вида “(999) 999999” или “999999”,
    //если код города отсутствует.

    //Преобразовать класс “Телефон” на работу со свойствами
    class Program
    {
        public static void Main(string[] args)
        {
        RepeatChoiseOperation:
            Console.WriteLine("У телефона присутствует код города или отсутсвует? (1-присутсвует, 0-отсутсвует)");
            int questionInt = Convert.ToInt32(Console.ReadLine());
            bool questionBool;
            if (questionInt == 1)
            {
                questionBool = true;
            }
            else if (questionInt == 0)
            {
                questionBool = false;
            }
            else
            {
                goto RepeatChoiseOperation;
            }

            Telephone TelephoneExemplar1 = new Telephone(questionBool);
        }
    }
}
