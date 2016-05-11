using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5._1
{
    class OOO : TypeClient
    {
        public string NameOrganization;
        public string BankAccount;

        public OOO(long id, string numberoftelephon, string sumorder, string nameorganization, string bankaccount) : base(id, numberoftelephon, sumorder)
        {
            NameOrganization = nameorganization;
            BankAccount = bankaccount;
        }
    }
}
