using System.Text.RegularExpressions;
using Balta.Domain.Accounts.ValueObjects.Exceptions;
using Balta.Domain.Shared.ValueObjects;

namespace Balta.Domain.Accounts.ValueObjects;

public sealed partial record Email : ValueObject
{
    #region Constants

    private const string Pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
    private const int MinLength = 6;
    private const int MaxLength = 160;
    
    #endregion

    #region Constructors

    private Email(string address)
    {
        Address = address;
    }

    #endregion

    #region Factories

    public static Email Create(string address)
    {
        if(string.IsNullOrWhiteSpace(address) || string.IsNullOrEmpty(address))
            throw new InvalidEmailLengthException("Email cannot be null or empty");

        address = address.Trim();
        address = address.ToLower();

        if (!EmailRegex().IsMatch(address))
            throw new InvalidEmailException("Email is invalid");
        
        return new Email(address);
    }
    
    #endregion
    
    #region Properties
    
    public string Address { get; set; }
    
    #endregion
    
    #region Operators

    public static implicit operator string(Email email) => email.ToString();

    #endregion

    public override string ToString() => Address;

    [GeneratedRegex(Pattern)]
    private static partial Regex EmailRegex();

}