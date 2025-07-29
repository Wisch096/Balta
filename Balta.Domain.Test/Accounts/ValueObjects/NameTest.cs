using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Accounts.ValueObjects.Exceptions;

namespace Balta.Domain.Tests.Accounts.ValueObjects;

public class NameTest
{
    private readonly Name _name = Name.Create("Matheus", "Wisch");
    
    [Fact]
    public void ShouldOverrideToStringMethod()
    {
        Assert.Equal("Matheus Wisch", _name.ToString());
    }
    
    [Fact]
    public void ShouldImplicitlyConvertToString()
    {
        string data = _name;
        Assert.Equal("Matheus Wisch", data);
    }
    
    [Fact]
    public void ShouldCreateNewName()
    {
        var name = Name.Create("Matheus", "Wisch");
        Assert.Equal("Matheus Wisch", name.ToString());
    }
    
    [Fact]
    public void ShouldFailFirstNameLengthIsNotValid()
    {
        Assert.Throws<InvalidFirstNameLengthException>(() =>
        {
          var name = Name.Create("Ma", "Wisch");  
        });
    }
    
    [Fact]
    public void ShouldFailLastNameLengthIsNotValid()
    {
        Assert.Throws<InvalidLastNameLengthException>(() =>
        {
            var name = Name.Create("Matheus", "Wi");  
        });
    }
}