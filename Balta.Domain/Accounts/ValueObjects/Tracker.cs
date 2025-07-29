using Balta.Domain.Shared.Abstractions;
using Balta.Domain.Shared.ValueObjects;

namespace Balta.Domain.Accounts.ValueObjects;

public sealed record Tracker : ValueObject
{
    #region Constructors
    
    public Tracker(DateTime createdAtUtc, DateTime updatedAtUtc)
    {
        CreatedAtUtc = createdAtUtc;
        UpdatedAtUtc = updatedAtUtc;
    }
    
    #endregion
    
    #region Factories

    public static Tracker Create(IDateTimeProvider dateTimeProvider) 
        => new(dateTimeProvider.UtcNow, dateTimeProvider.UtcNow);
    
    public static Tracker Create(DateTime createdAt, DateTime updatedAt) 
        => new(createdAt, updatedAt);

    #endregion
    
    #region Properties

    public DateTime CreatedAtUtc { get; }
    public DateTime UpdatedAtUtc { get; private set; }

    #endregion

    #region Methods 
    
    public void Update(IDateTimeProvider dateTimeProvider)
    {
        UpdatedAtUtc = dateTimeProvider.UtcNow;
    }
    
    #endregion
    
}