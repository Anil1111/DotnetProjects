using System.Linq;
using FluentAssertions;
using LinkedLists.Classes;
using Xunit;

namespace Generics.Tests
{
    public class RemoveLinkedListTests
    {
        [Fact]
        public void RemoveWhere_RemoveLessThanFour_LessThanFourRemoved()
        {
            var list = new RemoveLinkedList<int>(1, 2, 3, 4, 5, 6);

            list.Should().NotBeEmpty().And.HaveCount(6);
            list.RemoveWhere(val => val < 4);
            list.Should().NotBeEmpty().And.HaveCount(3);
            list.Should().BeEquivalentTo(4, 5, 6);
        }

        [Fact]
        public void RemoveWhere_GreaterThanFour_ReturnEquivalentValues()
        {
            var list = new RemoveLinkedList<int>(1,2,3,4,5,6);
            list.Should().NotBeEmpty().And.HaveCount(6);

            list.RemoveWhere(val => val > 4);
            list.Should().NotBeEmpty().And.HaveCount(4);
            list.Should().BeEquivalentTo(1, 2, 3, 4);
        }

    }
}
