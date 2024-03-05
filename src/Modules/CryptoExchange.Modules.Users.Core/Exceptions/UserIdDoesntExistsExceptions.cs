using CryptoExchange.Shared.Abstractions.Exceptions;

namespace CryptoExchange.Modules.Users.Core.Exceptions
{
    public class UserIdDoesntExistsExceptions : CryptoExchangeException
    {
        public string Id { get; set; }
        public UserIdDoesntExistsExceptions(string id) : base($"Invalid username `{id}`")
        {
            Id = id;

        }
    }
}