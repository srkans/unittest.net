using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_ArgIsNull_ThrowArgumentNullException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(()=>stack.Push(null), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Push_ValidArg_AddTheObjectToTheStack()
        {
            var stack = new Fundamentals.Stack<string>();
            
            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_Empty_ReturnZero()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(()=>stack.Pop(), Throws.TypeOf<InvalidOperationException>());

        }

        [Test]
        public void Pop_StackWithAFewObject_ReturnObjectOnTheTop()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            Assert.That(()=>stack.Pop(),Is.EqualTo("c"));
        }

        [Test]
        public void Pop_StackWithAFewObject_RemoveObjectOnTheTop()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Pop();

            Assert.That(()=>stack.Peek(),Is.EqualTo("b"));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(()=>stack.Peek(),Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTopOfTheStack()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");

            var result = stack.Peek();

            Assert.That(result,Is.EqualTo("b"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveOnTopOfTheObject()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");

            var result = stack.Peek();

            Assert.That(()=>stack.Count, Is.EqualTo(2));
        }
    }
}
