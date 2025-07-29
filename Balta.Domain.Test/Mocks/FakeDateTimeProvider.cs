using Balta.Domain.Shared.Abstractions;

namespace Balta.Domain.Tests.Mocks;

public class FakeDateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow { get; } = new DateTime(2025, 2, 3, 12, 7, 45, DateTimeKind.Utc);
}