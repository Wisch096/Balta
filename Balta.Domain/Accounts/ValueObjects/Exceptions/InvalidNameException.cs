using Balta.Domain.Shared.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions;

public sealed class InvalidNameException(string message) : DomainException(message);
