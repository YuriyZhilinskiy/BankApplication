using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgramm
{
    internal abstract class Card
    {
        public CardHolder NameCardHolder { get; set; }

        public int IdCard { get;}

        public double BalanceCard { get; set; }

        public Card(string name, int numCard, double balance)
        {
          //  NameCardHolder = name;
            IdCard = numCard;
            BalanceCard = balance;
        }

        public abstract bool BalanceDown(double downSumm);
        public abstract void BalanceUp(double upSumm);

        public abstract string GetFullCardInfo();
        
    }
}
