using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class GoldCard : DiscountCard
    {
        public GoldCard(string owner, decimal turnover)
        {
            Owner = owner;
            Turnover = turnover;
            DiscountRate = discountRateCalc();
        }

        public override decimal calculateDiscount()
        {
            return PurchaseValue * (DiscountRate/100);
        }
        private decimal discountRateCalc()
        {
            int percentHundred = (int)Turnover / 100;
            if (Turnover < 100) return 2;
            else
            {
                if (2 + percentHundred > 10) return 10;
                else return 2 + percentHundred;
            }
        }
    }
}
