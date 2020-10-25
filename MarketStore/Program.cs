using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountCard card;
            card = new BronzeCard("Ivan Dragiev", 102);
            card.setValueOfPurchase(250);
            card.getCardInfo();

            card = new SilverCard("Georgi", 428);
            card.setValueOfPurchase(325);
            card.getCardInfo();

            card = new GoldCard("Ivan", 850);
            card.setValueOfPurchase(1999);
            card.getCardInfo();
        }
    }
}
