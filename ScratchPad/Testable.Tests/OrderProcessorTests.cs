using System;
using NUnit.Framework;
using Testable.Classes;

namespace Testable.Tests
{
    [TestFixture]
    public class OrderProcessorTests
    {
        [Test]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            Assert.That(() => orderProcessor.Process(order), Throws.InvalidOperationException);
        }

        [Test]
        public void Process_OrderIsNotShipped_SetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.That(order.IsShipped, Is.True);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }

    }

}