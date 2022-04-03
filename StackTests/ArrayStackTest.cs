using Stack.Contracts;
using System.Collections.Generic;
using Xunit;

namespace StackTests
{
    public class ArrayStackTest
    {
        private readonly IStack<char> _stack;

        public ArrayStackTest()
        {
            _stack = new Stack.Stack<char>(new List<char> { 's', 'e', 'l', 'a', 'm' });

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