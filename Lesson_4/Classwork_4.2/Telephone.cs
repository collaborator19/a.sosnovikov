using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_4._2
{
    class Telephone
    {
        private string CodeOfCity = "(999)";
        private string NumberOfTelephone = "999999";
        public bool QuestionAboutCodeOfCity;

        public Telephone(bool QuestionAboutCodeOfCity)
        {
            if (QuestionAboutCodeOfCity == true)
            {
                Console.WriteLine(CodeOfCity + " " + NumberOfTelephone);
            }
            else
            {
                Console.WriteLine(NumberOfTelephone);
            }
        }
    }
}
