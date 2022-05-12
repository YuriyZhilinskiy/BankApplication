using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgramm
{
    internal class CreditCard : Card
    {
        public double CreditLimit { get; set; }
        public CreditCard(string name, int numCard, double balance, int raiting) : base(name, numCard, balance)
        {
            CreditLimit = balance * raiting * 1.10;
        }

        public override bool BalanceDown(double downSumm)
        {
            if (BalanceCard + CreditLimit - downSumm <= 0)
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
            return "\nID Card: " + IdCard + ", Type card: CC, Name: " + NameCardHolder + ", Balance: " + GetBalance() + ", Credit limit: " + CreditLimit;
        }
    }
}
