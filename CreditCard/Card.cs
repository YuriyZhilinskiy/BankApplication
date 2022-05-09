using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgramm
{
    internal class Card
    {
        public string nameCardHolder;
        public int IdCard;
        public double balanceCard;

        public Card(string name, int numCard, double balance)
        {
            nameCardHolder = name;
            IdCard = numCard;
            balanceCard = balance;
        }

        public virtual void BalanceDown(double downSumm)
        {
            if (balanceCard - downSumm <= 0)
            {
                Console.WriteLine("Out of limit, you can't spend so much!");
            }
            else
            {
                balanceCard -= downSumm;
            }
        }
        public void BalanceUp(double upSumm)
        {
            balanceCard += upSumm;
        }
        public double GetBalance()
        {
            return balanceCard;
        }
        public virtual string GetFullCardInfo()
        {
            return "\nID Card: " + IdCard + ", Name: " + nameCardHolder + ", Balance: " + GetBalance();
        }
    }
}
