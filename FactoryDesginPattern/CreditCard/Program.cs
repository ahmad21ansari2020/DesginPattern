// See https://aka.ms/new-console-template for more information


using CreditCard;
Console.Write("Select Card Type from \n 1 : MoneyBack \n 2 : Titanium \n 3 : Platinium \n Card Type : ");
var creditType = Console.ReadLine();
if (creditType != null)
{
    ICreditCard cardDetails = CreditCardFactory.GetCreditCard(creditType);

    if (cardDetails != null)
    {
        Console.WriteLine("CardType : " + cardDetails.GetCardType());
        Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
        Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
    }
    else
    {
        Console.Write("Invalid Card Type");
    }
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();
