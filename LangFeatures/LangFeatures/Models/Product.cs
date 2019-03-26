namespace LangFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }

        public string Name { get; set; }
        public string Category { get; set; } = "Water Sports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }

       

        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };

            Product lifeJacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            kayak.Related = lifeJacket;

            return new Product[] {kayak, lifeJacket, null};
        }
    }
}
