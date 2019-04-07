using DIBasics.Classes;
using Xunit;

namespace DIBasics.Tests
{
    
    public class SalutationTests
    {
        [Fact]
        public void Exclaim_WhenCalled_ReturnsCorrectMessage()
        {
            var writer = new SpyMessageWriter();
            var sut = new Salutation(writer);
            sut.Exclaim();
            Assert.Equal("Executing exclamation...", writer.WrittenMessage);
        }
    }
}
