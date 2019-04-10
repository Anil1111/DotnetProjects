using GenBasic.Classes;
using Generics.Tests.Utility.Classes;
using Xunit;

namespace Generics.Tests
{
    public class InterfaceRepositoryTests
    {
        [Fact]
        public void Add_WhenCalled_NotEmptyAndHasOne()
        {
            IRepository<Book> repository = new AnotherRepo<Book>();
            repository.Add(new Book {Author = "Kelly Washington", Title = "My better days"});
            Assert.NotEmpty(repository.All());
            Assert.Single(repository.All());
        }
    }
}
