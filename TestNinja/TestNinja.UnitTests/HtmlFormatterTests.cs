using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formmatter = new HtmlFormatter();
            var result = formmatter.FormatAsBold("abc");

            //specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //more general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc").IgnoreCase);




        }

    }
}
