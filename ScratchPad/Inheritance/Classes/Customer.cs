using System;

namespace Inheritance.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(true);
            Console.WriteLine(rating == 0 ? "Promoted to level 1" : "Promoted to level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }

    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
           
        }
    }
}
