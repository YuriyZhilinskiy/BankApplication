using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgramm
{
    internal class Bank
    {
        private List<Card> Cards; 
        public string BankName { get; set; }
         public double RefundingRate { get; set; }
        public double BankInterest { get; set; }
        public double TransferFee { get; set; }

        public Bank(double refundingRate, double transferFee)
        {
            Cards = new List<Card>();
            BankInterest = refundingRate + 3;
            TransferFee = transferFee;
        }
        public void IssueCard (string name, double startBalance, int creditRating, double transferFee)
        {
            if (creditRating == 0)
            {
                Cards.Add(new VirtualCard(name, Cards.Count(), startBalance, transferFee));
            }
            else if (creditRating < 0)
            {
                Cards.Add(new DebetCard(name, Cards.Count(), startBalance));
            }
            else
            {
                Cards.Add(new CreditCard(name, Cards.Count(), startBalance, creditRating));
            }
        }
      
        public string GetFullCardsInfo()
        {
            string fullCardsInfo = "";
            foreach (Card card in Cards)
            {
                fullCardsInfo += card.GetFullCardInfo();
                fullCardsInfo += " ";
            }
            return fullCardsInfo;
        }

        public bool TransferMoney(int sourceCardNumber, int targetCardNumber, double sum)
        {
            Card sourceCard = null, targetCard = null;

            foreach (Card card in Cards)
            {
                if (card.IdCard == sourceCardNumber)
                {
                    sourceCard = card;
                }
                else if (card.IdCard == targetCardNumber)
                {
                    targetCard = card;
                }
            }

            if (sourceCard == null || targetCard == null)
            {
                return false;
            }

            if (sourceCard.BalanceDown(sum) == true)
            {
                targetCard.BalanceUp(sum);
                return true;
            }

            return false;
        }
    }
}
