using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Classwork
{
    /*
    //Создать класс “Телефон”, который содержит следующие данные: код
    //города, номер телефона, которые не могут быть изменены. Добавить
    //метод, который возвращает строку вида “(999) 999999” или “999999”,
    //если код города отсутствует.
    class Telephone
    {
        private string CodeOfCity = "(999) ";
        private string NumberOfTelephone = "999999";
        public bool QuestionAboutCodeOfCity;

        public Telephone(bool QuestionAboutCodeOfCity)
        {
            if (QuestionAboutCodeOfCity == true)
            {
                Console.WriteLine(CodeOfCity + NumberOfTelephone);
            }
            else
            {
                Console.WriteLine(NumberOfTelephone);
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            RepeatChoiseOperation:
            Console.WriteLine("У телефона присутствует код города или отсутсвует? (1-присутсвует, 0-отсутсвует)");
            int QuestionInt = Convert.ToInt32(Console.ReadLine());
            bool QuestionBool;
            if (QuestionInt == 1)
            {
                QuestionBool = true;
            }
            else if (QuestionInt == 0)
            {
                QuestionBool = false;
            }
            else
            {
                goto RepeatChoiseOperation;
            }

            Telephone TelephoneExemplar1 = new Telephone(QuestionBool);
            
            
        }
    }
    */
    //Преобразовать класс “Телефон” на работу со свойствами
    class Telephone
    {
        private string _CodeOfCity = "(999) ";
        private string _NumberOfTelephone = "999999";
        public bool _QuestionAboutCodeOfCity;

        public bool QuestionAboutCodeOfCity
        {
            get { return _QuestionAboutCodeOfCity; }
            set
            {
                if (value == true)
                {
                    Console.WriteLine(_CodeOfCity + _NumberOfTelephone);
                }
                else
                {
                    Console.WriteLine(_NumberOfTelephone);
                }
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
        RepeatChoiseOperation:
            Console.WriteLine("У телефона присутствует код города или отсутсвует? (1-присутсвует, 0-отсутсвует)");
            int QuestionInt = Convert.ToInt32(Console.ReadLine());
            bool QuestionBool;
            if (QuestionInt == 1)
            {
                QuestionBool = true;
            }
            else if (QuestionInt == 0)
            {
                QuestionBool = false;
            }
            else
            {
                goto RepeatChoiseOperation;
            }

            

            //Telephone TelephoneExemplar1 = new Telephone(QuestionBool);
        }
    }
}
