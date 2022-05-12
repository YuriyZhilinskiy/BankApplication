using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgramm
{
    internal class VirtualCard : Card
    {  

        public double TransferFee { get; set; }
        public VirtualCard(string name, int numCard, double balance, double transferFee) : base(name, numCard, balance)
        {
            TransferFee = transferFee;
        }

        public override bool BalanceDown(double downSumm)
        {
            if (BalanceCard - downSumm <= 0)
            {
               return false;
            }
            BalanceCard -= downSumm + downSumm * TransferFee / 100;
            return true;
        }

        public override void BalanceUp(double upSumm)
        {
            BalanceCard += upSumm - upSumm * TransferFee / 100;
        }

        public double GetBalance()
        {
            return BalanceCard;
        }
        public override string GetFullCardInfo()
        {
            return "\nID Card: " + IdCard + ", Type card: VC, Name: " + NameCardHolder + ", Balance: " + GetBalance();
        }
    }
}

