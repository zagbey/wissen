using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirrtualReloaded
{
    internal class Eft:MoneyTransfer
    {
        public override string TransferType
        {
            get
            {
                return "Eft";
            }
        }
    }
}
