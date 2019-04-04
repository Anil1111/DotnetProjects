using WorkingWithMVC.Models;
using Xunit;

namespace WorkingWithMVC.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_ChangeProductName_ReturnsNewName()
        {
            var p = new Product { Name = "Test", Price = 100M };
            var result = p.Name = "New Name";
            Assert.Equal("New Name", result);
        }

        [Fact]
        public void Product_ChangeProductPrice_ReturnsNewPrice()
        {
            var p = new Product { Name = "Test", Price = 100M };
            var result = p.Price = 200M;
            Assert.Equal(200M, result);
        }
    }
}
