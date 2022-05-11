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
        public VirtualCard(string name, int numCard, double balance) : base(name, numCard, balance)
        {
            TransferFee = 0.03;
        }

        public override void BalanceDown(double downSumm)
        {
            if (BalanceCard - downSumm <= 0)
            {
                Console.WriteLine("Out of limit, you can't spend so much!");
            }
            else
            {
                BalanceCard -= downSumm - downSumm * TransferFee;
            }
        }

        public override void BalanceUp(double upSumm)
        {
            BalanceCard += upSumm - upSumm * TransferFee;
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

