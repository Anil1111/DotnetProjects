using System.Linq;
using GenBasic.Classes;
using Generics.Tests.Utility.Classes;
using Xunit;

namespace Generics.Tests
{
    public class RepositoryTests
    {
        [Fact]
        public void Add_WhenAddingAObject_ShouldNotBeEmpty()
        {
            var repository = new Repository<Person>();

            repository.Add(new Person{FirstName = "Anthony", LastName = "Hollis"});

            Assert.NotEmpty(repository.All());
            Assert.Single(repository.All());

        }

        [Fact] public void Get_WhenCalled_FirstNameAndLastNameShouldBeValid()
        {
            var repository = new Repository<Person>();

            repository.Add(new Person {FirstName = "Anthony", LastName = "Hollis"});
            var first = repository.Get(0);

            Assert.NotNull(first);
            Assert.Equal("Anthony", first.FirstName);
            Assert.Equal("Hollis", first.LastName);

        }

        [Fact]
        public void Delete_WhenCalled_RepoShouldBeEmpty()
        {
            var repository = new Repository<Person>();
            var person = new Person {FirstName = "Anthony", LastName = "Hollis"};
            repository.Add(person);

            Assert.NotEmpty(repository.All());
            Assert.Single(repository.All());

            repository.Delete(person);

            Assert.Empty(repository.All());
        }
    }
}
