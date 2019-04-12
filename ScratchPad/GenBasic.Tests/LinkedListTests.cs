using LinkedLists.Classes;
using Xunit;
using Person = Generics.Tests.Utility.Classes.Person;

namespace Generics.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void Get_WhenInstantiatingNewList_ShouldBeNull()
        {
            LinkedList<Person> list = new LinkedList<Person>();
            Assert.Equal(0, list.Count);
            Assert.Null(list.Get(0));
        }

        [Fact]
        public void Get_WhenAddingOneElement_ShouldReturnCorrectValues()
        {
            LinkedList<Person> list = new LinkedList<Person>();
            list.Insert(new Person{FirstName = "Anthony", LastName = "Hollis"});
            Assert.NotNull(list.Get(0));
            Assert.Equal("Anthony", list.Get(0).FirstName );
            Assert.Equal("Hollis", list.Get(0).LastName);
        }

        [Fact]
        public void Get_InstantiateWithInt_ShouldBeNull()
        {
            LinkedList<int> list = new LinkedList<int>();
            Assert.Equal(0, list.Count);
            Assert.Equal(0, list.Get(0));
        }

        [Fact]
        public void Get_WhenAddingOneInt_ShouldReturnCorrectValues()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Insert(42);
            Assert.Equal(1, list.Count);
            Assert.Equal(42, list.Get(0));
        }
    }
}
