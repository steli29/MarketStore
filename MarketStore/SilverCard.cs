using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class SilverCard: DiscountCard
    {
        public SilverCard(string owner, decimal turnover)
        {
            this.Owner = owner;
            this.Turnover = turnover;
            this.DiscountRate = 2m;
        }

        public override decimal calculateDiscount()
        {
            if (Turnover > 300) DiscountRate = 3.5m;
            return PurchaseValue * (DiscountRate/100);
        }
    }
}
