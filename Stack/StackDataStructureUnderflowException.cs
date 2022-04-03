namespace Stack
{
    public class StackDataStructureUnderflowException : Exception
    {
        public StackDataStructureUnderflowException(int size = 4, string message = "Stack Overflow Exception")
             : base(string.Concat(message, $" The length of stack is {size}!"))
        {

        }
    }
}
