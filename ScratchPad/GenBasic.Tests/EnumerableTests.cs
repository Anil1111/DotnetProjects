using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FrameWork.Classes;
using Xunit;

namespace Generics.Tests
{
    public class EnumerableTests
    {
        [Fact]
        public void ForEach_WhenInvoked_ReturnsObjectsInCollection()
        {
            var Anthony = new Person() { FirstName = "Anthony", LastName = "Hollis" };
            var Jessie = new Person() { FirstName = "Jessie", LastName = "Carlsbad" };
            var Lynda = new Person() { FirstName = "Lynda", LastName = "Wilson" };

            var people = new People(Anthony, Jessie, Lynda);
            people.Should().NotBeEmpty().And.HaveCount(3);

            foreach (var person in people)
            {
                person.FirstName.Should().NotBeNullOrEmpty();
                person.LastName.Should().NotBeNullOrEmpty();
            }

        }

        [Fact]
        public void ToList_WhenInvoked_ReturnsObjectsInCollection()
        {
            var Anthony = new Person() { FirstName = "Anthony", LastName = "Hollis" };
            var Jessie = new Person() { FirstName = "Jessie", LastName = "Carlsbad" };
            var Lynda = new Person() { FirstName = "Lynda", LastName = "Wilson" };

            var people = new People(Anthony, Jessie, Lynda);
            List<Person> list = people.ToList(); //IEnumerable can be converted to a list
            list.Should().NotBeEmpty().And.HaveCount(3);
        }

        [Fact]
        public void ToArray_WhenInvoked_ReturnsObjectsInCollection()
        {
            var Anthony = new Person() { FirstName = "Anthony", LastName = "Hollis" };
            var Jessie = new Person() { FirstName = "Jessie", LastName = "Carlsbad" };
            var Lynda = new Person() { FirstName = "Lynda", LastName = "Wilson" };

            var people = new People(Anthony, Jessie, Lynda);
            Person[] array = people.ToArray();
            array.Should().NotBeEmpty().And.HaveCount(3);
        }

        [Fact]
        public void Count_WhenInvoked_ReturnsTheCorrectCount()
        {
            var Anthony = new Person() { FirstName = "Anthony", LastName = "Hollis" };
            var Jessie = new Person() { FirstName = "Jessie", LastName = "Carlsbad" };
            var Lynda = new Person() { FirstName = "Lynda", LastName = "Wilson" };

            var people = new People(Anthony, Jessie, Lynda);
            people.Count().Should().Be(3);
        }

        [Fact]
        public void AddAndRemove_WhenInvoked_RemovesAndAddsToCollection()
        {
            var Anthony = new Person() { FirstName = "Anthony", LastName = "Hollis" };
            var Jessie = new Person() { FirstName = "Jessie", LastName = "Carlsbad" };
            var Lynda = new Person() { FirstName = "Lynda", LastName = "Wilson" };

            var list = new List<Person>();
            list.Add(Anthony);
            list.Add(Jessie);
            list.Should().NotBeEmpty().And.HaveCount(2);

            list.Insert(0, Lynda);
            list.Should().NotBeEmpty().And.HaveCount(3);

            list.RemoveAt(0);
            list.Should().NotBeEmpty().And.HaveCount(2);

            list.Remove(Jessie);
            list.Should().NotBeEmpty().And.HaveCount(1);

            list.Clear();
            list.Should().BeEmpty();

            list.AddRange(new[] { Anthony, Jessie });
            list.Should().NotBeEmpty().And.HaveCount(2);

            list.InsertRange(0, new[] { Lynda });
            list.Should().NotBeEmpty().And.HaveCount(3);
        }

        [Fact]
        public void TestFromEnumerable_WhenInvoked_ShouldHaveCorrectCount()
        {
            List<int> list = (new[] { 8, 9, 3, 4, 6 }).ToList();
            list.Should().NotBeEmpty().And.HaveCount(5);
        }

        [Fact]
        public void CopyAndGetRange_WhenInvoked_ShouldReturnExpectedCollection()
        {
            List<int> list = new List<int>(new[] { 8, 9, 3, 4, 6 });
            int[] array = new int[5];
            list.CopyTo(array);
            array.Should().BeEquivalentTo(new[] { 8, 9, 3, 4, 6 });

            List<int> range = list.GetRange(1, 2);
            range.Should().NotBeEmpty().And.HaveCount(2).And.BeEquivalentTo(new[] { 9, 3 });
        }

        [Fact]
        public void Contains_WhenInvoked_ShouldReturnExpectedBehavior()
        {
            var Anthony = new Person() { FirstName = "Anthony", LastName = "Hollis" };
            var Jessie = new Person() { FirstName = "Jessie", LastName = "Carlsbad" };
            var Lynda = new Person() { FirstName = "Lynda", LastName = "Wilson" };

            List<Person> list = new List<Person>(new[] { Anthony, Jessie });
            list.Contains(Anthony).Should().BeTrue();
            list.Contains(Lynda).Should().BeFalse();

            list.IndexOf(Anthony).Should().Be(0);
            list.Exists(x => x.FirstName == "Anthony").Should().BeTrue();
            list.TrueForAll(x => x.FirstName != null).Should().BeTrue();
        }

        [Fact]
        public void Find_WhenInvoked_ShouldReturnExpectedBehavior()
        {
            var Anthony = new Person() { FirstName = "Anthony", LastName = "Hollis" };
            var Jessie = new Person() { FirstName = "Jessie", LastName = "Carlsbad" };
            var Lynda = new Person() { FirstName = "Lynda", LastName = "Wilson" };

            List<Person> list = new List<Person>(new[] { Anthony, Jessie, Lynda });
            var found = list.Find(x => x.FirstName == "Anthony");
            found.Should().NotBeNull().And.Be(Anthony);

            found = list.FindLast(x => x.LastName.ToLower().Contains("c"));
            found.Should().NotBeNull().And.Be(Jessie);

            IEnumerable<Person> foundPeople = list.FindAll(x => x.LastName.ToLower().Contains("s"));
            foundPeople.Should().NotBeEmpty().And.HaveCount(3);


        }

        [Fact]
        public void Sort_WhenInvoked_ShouldReturnExpectedBehavior()
        {
            List<int> list = new List<int>(new[] { 8, 9, 3, 4, 6 });
            list.Should().NotBeAscendingInOrder();

            list.Sort();
            list.Should().BeInAscendingOrder();

            list.Sort((first, second) => first > second ? -1 : 1);
            list.Should().BeInDescendingOrder();
        }

        [Fact]
        public void ForEach_WhenInvoked_ShouldReturnExpectedBehavior()
        {
            List<int> list = new List<int>(new[] { 8, 9, 3, 4, 6, 6 });
            int total = 0;
            list.ForEach(i => total = total + i);
            total.Should().Be(36);
        }

        [Fact]
        public void ConvertAll_WhenInvoked_AllElementsShouldBeConverted()
        {
            List<int> list = new List<int>(new[] { 8, 9, 4, 3, 6 });
            List<double> converted = list.ConvertAll(i => (double)i);
            converted.Should().NotBeEmpty().And.HaveCount(5);
        }

    }
}
