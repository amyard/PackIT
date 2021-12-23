using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class InvalidTravelDayException : PackItException
    {
        public ushort Days { get; }

        public InvalidTravelDayException(ushort days) : base($"Value 'days' is invalid travel days.")
        {
            Days = days;
        }
    }
}