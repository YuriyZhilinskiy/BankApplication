using System;
using BankProgramm;

Console.Write("Enter refunding rate in %: ");
double refundingRate = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the bank transfer charge in %: ");
double transferFee = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the maximum number of cards: ");
int cardsCount = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of issued cards: ");
int newCardsCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Bank M7_Bank = new Bank(refundingRate, transferFee);



    for (int i = 0; i < newCardsCount; i++)
    {
        Console.Write("Enter your Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your start balance: ");
        double startBalance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your credit rating: ");
        int creditRating = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        M7_Bank.IssueCard(name, startBalance, creditRating, transferFee);
    }


Console.WriteLine(M7_Bank.GetFullCardsInfo());

Console.Write("\nDo you want transfer money? (1 - Yes, 0 - No) ");
string choice = Console.ReadLine();

if (choice == "1")
{
    Console.Write("Enter ID card for source of payment: "); 
    int sourceCardNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter ID card for target of payment: ");
    int targetCardNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter summ of transfer: "); 
    double sumTransfer = Convert.ToDouble(Console.ReadLine());

    bool operationResult = M7_Bank.TransferMoney(sourceCardNumber, targetCardNumber, sumTransfer);
}
else
{
    Console.Write("Good by!");
}

Console.WriteLine(M7_Bank.GetFullCardsInfo());
