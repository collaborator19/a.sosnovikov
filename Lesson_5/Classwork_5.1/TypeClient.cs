using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5._1
{
    class TypeClient
    {
        public readonly long Id;
        public string NumberOfTelephon;
        public string SumOrder;

        public TypeClient(long id, string numberoftelephon, string sumorder)
        {
            Id = id;
            NumberOfTelephon = numberoftelephon;
            SumOrder = sumorder;
        }
    }
}
