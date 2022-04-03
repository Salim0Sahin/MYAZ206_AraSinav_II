namespace Stack
{
    public class StackDataStructureOverflowException : Exception
    {
        public StackDataStructureOverflowException(int size = 4, string message = "Stack Overflow Exception!")
            : base(string.Concat(message, $" The length of stack is {size}!"))
        {

        }
    }
}
