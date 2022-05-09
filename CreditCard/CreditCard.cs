using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgramm
{
    internal class CreditCard : Card
    {
        public double creditLimit;
        public CreditCard(string name, int numCard, double balance, int raiting) : base(name, numCard, balance)
        {
            creditLimit = balance * raiting * 1.10;
        }

        public override void BalanceDown(double downSumm)
        {
            if (balanceCard + creditLimit - downSumm <= 0)
            {
                Console.WriteLine("Out of limit, you can't spend so much!");
            }
            else
            {
                balanceCard -= downSumm;
            }
        }

        public override string GetFullCardInfo()
        {
            return base.GetFullCardInfo() + ", Credit limit: " + creditLimit;
        }
    }
}
