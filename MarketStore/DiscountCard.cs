using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
   public abstract class DiscountCard
    {
        protected decimal PurchaseValue { get; set; }
        protected decimal DiscountRate { get; set; }
        protected string Owner { get; set; }
        protected decimal Turnover { get; set; }
        public abstract decimal calculateDiscount();
        public void setValueOfPurchase(decimal val)
        {
            PurchaseValue = val;
        }
        public decimal getGetTotalValue()
        {
            return PurchaseValue - this.calculateDiscount();
        }
        public void getCardInfo()
        {
            Console.WriteLine("Cardholder's name: " + Owner);
            Console.WriteLine("Purchase value: ${0:0.00}", PurchaseValue);
            Console.WriteLine("Discount rate: {0:0.00}%", DiscountRate);
            Console.WriteLine("Discount: ${0:0.00}", calculateDiscount());
            Console.WriteLine("Total value: {0:0.00}", getGetTotalValue());
        }
    }
}
