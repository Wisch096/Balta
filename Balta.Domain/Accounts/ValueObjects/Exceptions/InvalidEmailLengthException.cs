using Balta.Domain.Shared.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions;

public sealed class InvalidEmailLengthException(string message) 
    : DomainException(message);