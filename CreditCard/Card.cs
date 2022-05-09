using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgramm
{
    internal class Card
    {
        public string NameCardHolder { get; set; }
        public int IdCard { get; set; }
        public double BalanceCard { get; protected set; }

        public Card(string name, int numCard, double balance)
        {
            NameCardHolder = name;
            IdCard = numCard;
            BalanceCard = balance;
        }

        public virtual void BalanceDown(double downSumm)
        {
            if (BalanceCard - downSumm <= 0)
            {
                Console.WriteLine("Out of limit, you can't spend so much!");
            }
            else
            {
                BalanceCard -= downSumm;
            }
        }
        public void BalanceUp(double upSumm)
        {
            BalanceCard += upSumm;
        }
        public double GetBalance()
        {
            return BalanceCard;
        }
        public virtual string GetFullCardInfo()
        {
            return "\nID Card: " + IdCard + ", Name: " + NameCardHolder + ", Balance: " + GetBalance();
        }
    }
}
