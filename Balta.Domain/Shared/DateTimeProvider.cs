using Balta.Domain.Shared.Abstractions;

namespace Balta.Domain.Shared;

public class DateTimeProvider: IDateTimeProvider
{
    public DateTime UtcNow { get; } = DateTime.UtcNow;
}