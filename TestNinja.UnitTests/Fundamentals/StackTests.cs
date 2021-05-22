using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }

        [Test]
        public void Push_ObjectIsNull_ReturnArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        [TestCase("value1")]
        public void Push_NewValidItem_ReturnQuantityOfItems(string value)
        {
            var itemsCount = _stack.Count;
            _stack.Push(value);
            Assert.That(_stack.Count, Is.EqualTo(itemsCount+1));
        }

        [Test]
        public void Pop_ListIsEmpty_ReturnInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_GetValidItem_ReturnItemAdded()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");
            var itemQuantity = _stack.Count;
            var result = _stack.Pop();
            Assert.That(result, Is.EqualTo("c"));
            Assert.That(_stack.Count, Is.EqualTo(itemQuantity-1));
        }

        [Test]
        public void Peek_ListIsEmpty_ReturnInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_GetTopValue_ReturnTopValue()
        {
            _stack.Push("Value 1");
            var countItems = _stack.Count;
            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo("Value 1"));
            Assert.That(_stack.Count, Is.EqualTo(countItems));
        }
    }
}
