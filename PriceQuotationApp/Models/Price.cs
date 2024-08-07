using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models
{
    public class Price
    {
        [Range(0, double.MaxValue)]
        public double Subtotal { get; set; }

        [Range(0, 100)]
        public int DiscountPercent { get; set; }

        public double DiscountAmount { get; private set; } = 0.00;

        public double Total { get; private set; } = 0.00;

        public void Calculate()
        {
            DiscountAmount = Subtotal * DiscountPercent / 100;
            Total = Subtotal - DiscountAmount;
        }
    }
}
