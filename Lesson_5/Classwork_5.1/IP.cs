using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5._1
{
    class IP : TypeClient
    {
        public string FIO;
        public string DateOfBirthday;

        public IP(long id, string numberoftelephon, string sumorder, string fio, string dateofbirthday) : base(id, numberoftelephon, sumorder)
        {
            FIO = fio;
            DateOfBirthday = dateofbirthday;
        }
    }
}
