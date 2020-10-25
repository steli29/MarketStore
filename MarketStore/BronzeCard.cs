using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class BronzeCard : DiscountCard
    {
        public BronzeCard(string owner, decimal turnover)
        {
            Owner = owner;
            Turnover = turnover;
        }
        public override decimal calculateDiscount()
        {
            if (Turnover >= 100 && Turnover <= 300) DiscountRate = 1;
            else if (Turnover > 300) DiscountRate = 2.5m;
            else DiscountRate = 0;
            return PurchaseValue * (DiscountRate / 100);
            
        }
    }
}
