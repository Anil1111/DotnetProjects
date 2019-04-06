namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculatorDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}