using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class PackingItemNotFoundException : PackItException
    {
        public string Message { get; }

        public PackingItemNotFoundException(string itemName) : base($"Packing item '{itemName}' was not found.")
            => itemName = itemName;
    }
}