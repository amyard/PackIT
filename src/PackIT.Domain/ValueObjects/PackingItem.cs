using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects
{
    public record PackingItem
    {
        public string Name { get; }
        public uint Quantity { get; }
        public bool IsPacked { get; init; }
        // init  basically means that initialize either only from the constructor or from object initializer 
        // so it's like immutable but gives flexibility to choose either you want to create set it from constructor or object initializer 
        public PackingItem(string name, uint quantity, bool isPacked = false)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new EmptyPackingListItemNameException();
            
            Name = name;
            Quantity = quantity;
            IsPacked = isPacked;
        }
    }
}