using Balta.Domain.Shared.ValueObjects;

namespace Balta.Domain.Accounts.ValueObjects;

public sealed record Name : ValueObject
{
    #region Constructors
    
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
    #endregion
    
    #region Properties

    public string FirstName { get; }
    public string LastName { get; }

    #endregion
    
    #region Operators 
    
    public static implicit operator string(Name name) => name.ToString();
    
    #endregion

    #region Overrides

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

    #endregion
}