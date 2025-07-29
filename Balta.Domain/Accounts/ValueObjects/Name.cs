using Balta.Domain.Accounts.ValueObjects.Exceptions;
using Balta.Domain.Shared.ValueObjects;

namespace Balta.Domain.Accounts.ValueObjects;

public sealed record Name : ValueObject
{
    #region Constants
    
    public const int MinLength = 3;
    public const int MaxLength = 60;
    
    #endregion
        
    #region Constructors
    
    private Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
    #endregion

    #region Factories

    public static Name Create(string firstName, string lastName)
    {
        if(string.IsNullOrWhiteSpace(firstName)
           || string.IsNullOrWhiteSpace(lastName)
           || string.IsNullOrEmpty(firstName)
           || string.IsNullOrEmpty(lastName))
            throw new InvalidNameException("Name is invalid");
        
        if(firstName.Length < MinLength)
            throw new InvalidFirstNameLengthException("First name at least 3 characters");
        
        if(firstName.Length > MaxLength)
            throw new InvalidFirstNameLengthException("First name at least 3 characters");
        
        if(lastName.Length < MinLength)
            throw new InvalidLastNameLengthException("Last name at least 3 characters");
        
        if(lastName.Length > MaxLength)
            throw new InvalidLastNameLengthException("Last name at least 3 characters");
        
        return new Name(firstName, lastName);
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