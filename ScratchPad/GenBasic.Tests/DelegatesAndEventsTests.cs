using GenBasic.Classes;
using Xunit;

namespace Generics.Tests
{
    public class DelegatesAndEventsTests
    {
        [Fact]
        public void OnDisplay_WhenInvoked_InvokedIsTrue()
        {
            var invoked = false;
            var shape = new Shape();
            shape.Displayed += (shape1, args) => invoked = true;
            shape.Display();
            Assert.True(invoked);
        }
    }
}
