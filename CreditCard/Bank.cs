using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgramm
{
    internal class Bank
    {
        public string BankName;
        public Card[] Cards;
        public int NumberOfIssuedCards;
        public int MaxNumberOfCards;
        public double refundingRate;
        public double bankInterest;

        public Bank(int cardsCount, double refundingRate)
        {
            MaxNumberOfCards = cardsCount;
            Cards = new Card[cardsCount];
            NumberOfIssuedCards = 0;
            bankInterest = refundingRate + 3;
        }
        public void IssueCard (string name, double startBalance, int creditRating)
        {
            if (creditRating <= 0)
            {
                Cards[NumberOfIssuedCards] = new Card(name, NumberOfIssuedCards, startBalance);
                NumberOfIssuedCards++;
            }
            else
            {
                Cards[NumberOfIssuedCards] = new CreditCard(name, NumberOfIssuedCards, startBalance, creditRating);
                NumberOfIssuedCards++;
            }
        }
        public int GetAvailableNumberOfCards()
        {
            return MaxNumberOfCards - NumberOfIssuedCards;
        }
        public string GetFullCardsInfo()
        {
            string fullCardsInfo = "";
            for (int i= 0; i < NumberOfIssuedCards; i++)
            {
                fullCardsInfo += Cards[i].GetFullCardInfo();
                fullCardsInfo += " ";
            }
            return fullCardsInfo;
        }

        public bool TransferMoney(int sourceCardNumber, int targetCardNumber, double sum)
        {
            Card sourceCard = null, targetCard = null;

            for (int index = 0; index < NumberOfIssuedCards; index++)
            {
                if (Cards[index].IdCard == sourceCardNumber)
                {
                    sourceCard = Cards[index];
                }
                else if (Cards[index].IdCard == targetCardNumber)
                {
                    targetCard = Cards[index];
                }
            }

            if (sourceCard == null || targetCard == null)
            {
                return false;
            }

            sourceCard.BalanceDown(sum);
            targetCard.BalanceUp(sum);

            return true;

        }
    }
}
