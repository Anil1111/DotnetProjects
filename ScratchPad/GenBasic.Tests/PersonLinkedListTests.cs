using System.Net.Http.Headers;
using LinkedLists.Classes;
using Xunit;

namespace Generics.Tests
{
    public class PersonLinkedListTests
    {
        [Fact]
        public void TestConstruction_ShouldBeNull()
        {
            var list = new PersonLinkedList();
            Assert.Equal(0, list.Count);
            Assert.Null(list.Get(0));
        }

        [Fact]
        public void Insert_AddOneMember_ReturnsCorrectData()
        {
            var list = new PersonLinkedList();
            list.Insert(new Person { FirstName = "Anthony", LastName = "Hollis" });
            Assert.Equal(1, list.Count);

            var person = list.Get(0);
            Assert.NotNull(person);

            Assert.Equal("Anthony", person.FirstName);
            Assert.Equal("Hollis", person.LastName);

        }

        [Fact]
        public void Get_WhenCalled_ReturnsTheCorrectNode()
        {
            var list = new PersonLinkedList();
            list.Insert(new Person { FirstName = "Chris", LastName = "Jones" });
            list.Insert(new Person { FirstName = "Paul", LastName = "Davies" });
            list.Insert(new Person { FirstName = "Laura", LastName = "Colburn" });

            Assert.Equal(3, list.Count);

            Person person = list.Get(0);
            Assert.NotNull(person);
            Assert.Equal("Laura", person.FirstName);
            Assert.Equal("Colburn", person.LastName);

            person = list.Get(2);
            Assert.NotNull(person);
            Assert.Equal("Chris", person.FirstName);
            Assert.Equal("Jones", person.LastName);

            person = list.Get(1);
            Assert.NotNull(person);
            Assert.Equal("Paul", person.FirstName);
            Assert.Equal("Davies", person.LastName);
        }
    }
}
