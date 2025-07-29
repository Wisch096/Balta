using Balta.Domain.Accounts.ValueObjects;

namespace Balta.Domain.Tests.Accounts.ValueObjects;

public class NameTest
{
    private readonly Name _name = new Name("Matheus", "Wisch");
    
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
}