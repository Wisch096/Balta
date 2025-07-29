using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Shared.Abstractions;
using Balta.Domain.Tests.Mocks;

namespace Balta.Domain.Tests.Accounts.ValueObjects;

public class TrackerTest
{
    private readonly IDateTimeProvider _dateTimeProvider = new FakeDateTimeProvider();
    
    [Fact]
    public void ShouldCreateTrackerWithCurrentUtcDateTime()
    {
        var tracker = Tracker.Create(_dateTimeProvider);
        Assert.Equal(_dateTimeProvider.UtcNow, tracker.CreatedAtUtc);;
    }
}