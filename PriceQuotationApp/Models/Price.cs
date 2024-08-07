using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models
{
    public class Price
    {
        [Range(0, double.MaxValue, ErrorMessage = "The Subtotal must be a positive number")]
        public double Subtotal { get; set; }

        [Range(0, 100, ErrorMessage = "The Discount Percent must be between 0 and 100")]
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
