using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            //NotFound type
            Assert.That(result, Is.TypeOf<NotFound>());

            //NotFound type or one of it's derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IsIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }

    }
}
