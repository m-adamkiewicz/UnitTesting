using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        [Test]
        public void Push_ArgumentIsNull_ThrowArgumentNullException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }
        [Test]
        public void Push_ValidArg_AddTheObjectToTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }
        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }
        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void Pop_StackWithFewObjects_ReturnObjectOnTheTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");

            var result = stack.Pop();

            Assert.That(result, Is.EqualTo("d"));
        }
        [Test]
        public void Pop_StackWithFewObjects_RemoveObjectOnTheTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");

            var topObject = stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(3));
        }
        [Test]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => { var result = stack.Peek(); }, Throws.InvalidOperationException);
        }
        [Test]
        public void Peek_StackWithFewObjects_ReturnObjectOnTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("d"));
        }
        [Test]
        public void Pop_StackWithFewObjects_DoNotRemoveObjectOnTheTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");

            var topObject = stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(4));
        }
    }
}