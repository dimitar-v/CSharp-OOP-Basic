using System;

namespace HotelReservation
{
    public class PriceCalculator
    {
        private decimal price;
        private int deys;
        private Season season;
        private Discount discount;

        public PriceCalculator(Func<string> readData)
        {
            var info = readData().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            price = decimal.Parse(info[0]);
            deys = int.Parse(info[1]);
            season = Enum.Parse<Season>(info[2]);
            discount = info.Length == 4 ? Enum.Parse<Discount>(info[3]) : Discount.None;
        }

        public decimal Calculate() 
            => (price * deys * (int)season) * (1 - (decimal)discount / 100);
    }
}
