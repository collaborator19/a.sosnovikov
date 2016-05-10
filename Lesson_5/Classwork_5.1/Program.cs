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

    class Client
    {
        public readonly long Id;
        public string NumberOfTelephon;
        public string SummaZakaza;


        public Client(long id, string numberoftelephon, string summazakaza)
        {
            Id = id;
            NumberOfTelephon = numberoftelephon;
            SummaZakaza = summazakaza;
        }
    }

    class IP : Client
    {
        public string FIO;
        public string BD;

        public IP(long id, string numberoftelephon, string summazakaza, string fio, string bd) : base(id, numberoftelephon, summazakaza)
        {
            FIO = fio;
            BD = bd;
        }
    }
    class OOO : Client
    {
        public string Nazvanie;
        public string BankSchet;

        public OOO(long id, string numberoftelephon, string summazakaza, string nazvanie, string bankSchet) : base(id, numberoftelephon, summazakaza)
        {
            Nazvanie = nazvanie;
            BankSchet = bankSchet;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            IP IpExemplar1 = new IP(12, "777", "100500", "Иванов Иван Иванович", "01.01.2000");
            Console.WriteLine($"{ IpExemplar1.Id } { IpExemplar1.NumberOfTelephon} { IpExemplar1.SummaZakaza} { IpExemplar1.FIO} {IpExemplar1.BD}");
        }
    }
}
