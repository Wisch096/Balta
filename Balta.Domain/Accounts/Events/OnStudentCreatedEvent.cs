using Balta.Domain.Shared.Events.Abstractions;

namespace Balta.Domain.Accounts.Events;

public sealed record OnStudentCreatedEvent(
    Guid Id,
    string Name, 
    string Email) : IDomainEvent;