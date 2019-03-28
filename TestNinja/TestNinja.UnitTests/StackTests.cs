using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_WhenObjectIsNull_ThrowsArgumentNullException()
        {
            var stack = new Fundamentals.Stack<object>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ObjectAddedToList_ListIsEqualToOne()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_CountIsZero_ThrowsInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<object>();
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_RemoveItemFromList_CountIsOneLess()
        {
            var stack = new Fundamentals.Stack<object>();
            for (var i = 0; i < 5; i++)
            {
                stack.Push(new object());
            }

            stack.Pop();
            var result = stack.Count;
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Peek_CountIsZero_ReturnsInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<object>();
            Assert.That(()=>stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_Peeking_ReturnsTopStackValue()
        {
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            var result = stack.Peek();
            Assert.That(result, Is.EqualTo(2));
        }



    }
}
