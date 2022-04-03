using Stack;
using Xunit;

namespace StackTests
{
    public class StaticArrayStackTests
    {

        private readonly StaticArrayStack<int> _stack;
        public StaticArrayStackTests()
        {
            _stack = new StaticArrayStack<int>(4);
            _stack.Push(10);
            _stack.Push(20);
            _stack.Push(30);
        }

        [Theory]
        [InlineData(40)]
        public void Push_Test(int value)
        {
            // act
            _stack.Push(value);

            // assert
            Assert.Equal(4, _stack.Count);
        }

        [Fact]
        public void Push_StackDataStructureOverflowException_Test()
        {
            // act
            _stack.Push(40);

            // assert
            Assert.Throws<StackDataStructureOverflowException>(() => _stack.Push(50));
        }

        [Fact]
        public void Pop_StackDataStructureUnderflowException()
        {
            // act
            _stack.Pop();
            _stack.Pop();
            _stack.Pop();

            // assert
            Assert.Throws<StackDataStructureUnderflowException>(() => _stack.Pop());
        }

        [Fact]
        public void Peek_Test()
        {
            // 10 20 [30]
            // act
            var peek = _stack.Peek();

            // assert
            Assert.Equal(30, peek);
        }

        [Fact]
        public void GetEnumerator_Test()
        {
            _stack.Push(40);
            Assert.Collection(_stack,
                item => Assert.Equal(10, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(40, item));
        }



    }
}
