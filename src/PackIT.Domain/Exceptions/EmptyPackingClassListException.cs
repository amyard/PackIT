using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackingClassListException : PackItException
    {
        public EmptyPackingClassListException() : base("packing list name cannot be empty")
        {
        }
    }
}