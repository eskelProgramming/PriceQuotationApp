namespace PriceQuotationApp.Models
{
    public class Price
    {
        public double Subtotal { get; set; }

        public int DiscountPercent { get; set; }

        public double DiscountAmount { get; private set; }

        public double Total { get; private set; }

        public void Calculate()
        {
            DiscountAmount = Subtotal * DiscountPercent / 100;

            Total = Subtotal - DiscountAmount;
        }
    }
}
