using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5._1
{
    //Реализовать классы для описания клиентов двух типов: ИП и ООО.
    //Каждый тип клиента имеет идентификатор, основной телефон, сумма
    //заказа. У ИП указывается ФИО, дата рождения. У ООО указывается
    //название, банковский счет. Реализовать метод, который возвращает
    //отформатированное название и сумму заказа.

    class Program
    {
        public static void Main(string[] args)
        {
            IP IpExemplar1 = new IP(1, "8(800)", "500р.", "Иванов Иван Иванович", "01.01.2000");
            Console.WriteLine($"{ IpExemplar1.Id } { IpExemplar1.NumberOfTelephon} { IpExemplar1.SumOrder} { IpExemplar1.FIO} {IpExemplar1.DateOfBirthday}");

            OOO OOOExemplar1 = new OOO(id: 2, numberoftelephon: "9(900)", sumorder: "1000р.", nameorganization: "Рога и Копыта", bankaccount: "343255");
            Console.WriteLine($"{ OOOExemplar1.Id} { OOOExemplar1.NumberOfTelephon} {OOOExemplar1.SumOrder} {OOOExemplar1.NameOrganization} {OOOExemplar1.BankAccount}");
        }
    }
}
