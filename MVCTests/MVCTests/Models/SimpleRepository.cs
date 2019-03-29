using System.Collections.Generic;

namespace MVCTests.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer Ball", Price = 19.50M},
                new Product {Name = "Corner Flag", Price = 34.95M}
            };

            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
        }

        public IEnumerable<Product> Products => products.Values;

        private void AddProduct(Product p) => products.Add(p.Name, p);

    }
}
