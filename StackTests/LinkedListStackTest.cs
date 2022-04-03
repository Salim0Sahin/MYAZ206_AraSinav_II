using Stack.Contracts;
using Xunit;

namespace StackTests
{
    public class LinkedListStackTest
    {
        private IStack<char> _stack;
        public LinkedListStackTest()
        {
            _stack =
                new Stack.Stack<char>(
                    new char[] { 's', 'e', 'l', 'a', 'm' });
        }

        [Fact]
        public void Count_Test()
        {
            // act
            var count = _stack.Count;

            // assert
            Assert.Equal(5, count);
        }

        [Theory]
        [InlineData('m')]
        [InlineData('e')]
        [InlineData('r')]
        [InlineData('h')]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('a')]
        public void Push_Test(char value)
        {
            // Act
            _stack.Push(value);
            var peek = _stack.Peek();

            // Assert
            Assert.Equal(value, peek);
        }

        [Fact]
        public void Pop_Test()
        {
            // Act
            var pop = _stack.Pop();

            // Assert
            Assert.Equal('m', pop);
        }

        [Theory]
        [InlineData('m')]
        [InlineData('e')]
        [InlineData('r')]
        [InlineData('h')]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('a')]
        public void Peek_Test(char value)
        {
            // Act
            _stack.Push(value);

            var peek = _stack.Peek();

            // Assert
            Assert.Equal(value, peek);
        }
    }
}
