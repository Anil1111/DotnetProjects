using GenBasic.Classes;
using Generics.Tests.Utility.Classes;
using Xunit;

namespace Generics.Tests
{
   public class TypeInferenceTests
    {
        [Fact]
        public void Swap_WhenCalledWithIntegers_ValuesAreSwapped()
        {
            var first = 23;
            var second = 42;

            //Note: compiler is using type inference here
            //no need for TypeInference.Swap<int>(...);
            TyperInference.Swap(ref first, ref second);
            
            Assert.Equal(42, first);
            Assert.Equal(23, second);
        }

        [Fact]
        public void Deserialize_WhenCalled_ObjetIsDeserialized()
        {
            var person = new Person {FirstName = "Anthony", LastName = "Hollis"};
            
        }
    }
}
