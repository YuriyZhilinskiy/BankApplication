using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgramm
{
    internal class DebetCard : Card
    {
        public DebetCard(string name, int numCard, double balance): base(name, numCard, balance)
        {
           
        }

        public override bool BalanceDown(double downSumm)
        {
            if (BalanceCard - downSumm <= 0)
            {
               return false;
            }
            
            BalanceCard -= downSumm;
            return true;
        }
        public override void BalanceUp(double upSumm)
        {
            BalanceCard += upSumm;
        }
        public double GetBalance()
        {
            return BalanceCard;
        }
        public override string GetFullCardInfo()
        {
            return "\nID Card: " + IdCard + ", Type card: DC, Name: " + NameCardHolder + ", Balance: " + GetBalance();
        }
    }
}
