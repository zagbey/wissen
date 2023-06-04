using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirrtualReloaded
{
    internal abstract class MoneyTransfer
    {
        public abstract string TransferType { get; }
        public decimal Amount { get; set; }
        public string SenderIban { get; set; }
        public string ReceiverIban { get; set; }

        private string _description;
        public string Description
        {
            get
            {
                if (string.IsNullOrEmpty(_description))
                {
                    return $"{ReceiverIban} hesabına {Amount} Tl tutarında {TransferType} ile aktarıldı ";
                }
                else
                {
                    return _description ;
                }
            }
            set
            {
                _description = value;
            }
        }



        public virtual decimal Fee
        {
            get
            {
                const int MinLimit = 10000;
                const int LovFee = 4;
                const int HighFee = 10;

                return Amount < MinLimit ? LovFee : HighFee;
            }
        }
    }
}
