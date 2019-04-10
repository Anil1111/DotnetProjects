using System;
using GenBasic.Classes;
using Xunit;

namespace Generics.Tests
{
    public class SimpleListTests
    {
        [Fact]
        public void Get_WhenObjectRetrievedByIndex_ShouldReturnCorrectObject()
        {
            var simpleList = new SimpleList<object>();
            var toAdd = new Object();
            simpleList.Add(toAdd);

            var retrieved = simpleList.Get(0);
            Assert.Equal(toAdd, retrieved);
        }

        [Fact]
        public void Get_WhenRetrievingObjectOutsideOfRange_ShouldReturnNull()
        {
            var simpleList = new SimpleList<object>();
            var toAdd = new object();
            simpleList.Add(toAdd);

            var retrieved = simpleList.Get(1); //outside of range - returns default value for type
            Assert.Null(retrieved);
        }

        [Fact]
        public void Get_WhenCalled_ValueOrDefaultReturned()
        {
            var simpleList = new SimpleList<int>();
            simpleList.Add(3);

            var retrieved = simpleList.Get(0);
            Assert.Equal(3, retrieved);

            retrieved = simpleList.Get(1); //out of range - returns default value of type
            Assert.Equal(0, retrieved);
        }

        [Fact]
        public void Get_WhenCalledAgainstAStruct_ValueOrDefaultShouldBeReturned()
        {
            var simpleList = new SimpleList<TestStruct>();
            var toAdd = new TestStruct() {Entity = new object(), Value = 3};
            simpleList.Add(toAdd);

            var retrieved = simpleList.Get(0);
            Assert.Equal(toAdd, retrieved);

            //structs unlike classes are value types
            //therefore when you request outside the range
            //the entity object default value should be null
            //the int value default value should be 0
            retrieved = simpleList.Get(1); 
            Assert.Null(retrieved.Entity);
            Assert.Equal(0, retrieved.Value);
        }

    }

    public struct TestStruct
    {
        public object Entity;
        public int Value;
    }
}
