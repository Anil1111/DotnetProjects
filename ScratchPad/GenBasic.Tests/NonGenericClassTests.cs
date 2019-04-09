using Xunit;

namespace Generics.Tests
{
    public class NonGenericClassTests
    {
        [Fact]
        public void Swap_WhenCalledWithIntegers_FirstValShouldBeSecondVal()
        {
            var first = 23;
            var second = 42;

            GenBasic.Classes.NonGenericClass.Swap(ref first, ref second);
            Assert.Equal(42,first);
            Assert.Equal(23, second);
        }

        [Fact]
        public void Swap_WhenCalledWithStrings_FirstValShouldBeSecondVal()
        {
            var first = "Anthony";
            var second = "Hollis";

            GenBasic.Classes.NonGenericClass.Swap(ref first, ref second);
            Assert.Equal("Hollis", first);
            Assert.Equal("Anthony", second);
        }

        [Fact]
        public void Swap_WhenCalledWithObjects_FirstValShouldBeSecondVal()
        {
            var first = new object();
            var second = new object();
            var saveFirst = first;
            var saveSecond = second;

            GenBasic.Classes.NonGenericClass.Swap(ref first, ref second);

            Assert.Equal(saveSecond, first);
            Assert.Equal(saveFirst, second);
        }
    }
}
