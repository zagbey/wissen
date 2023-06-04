using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirrtualReloaded
{
    internal  class Fast:MoneyTransfer
    {
        public override string TransferType
        {
            get
            {
                return "Fast transfer";
            }
        }
        public override decimal Fee
        {
            get
            {
                return Amount * 0.01m;
            }
        }
    }
}
