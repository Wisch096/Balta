using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Accounts.ValueObjects.Exceptions;

namespace Balta.Domain.Tests.Accounts.ValueObjects;

public class EmailTest
{
    [Theory]
    [InlineData("test@matheus.io")]
    [InlineData("test@gmail.com")]
    [InlineData("test@hotmail.com")]
    public void ShouldCreateAnEmail(string address)
    {
        var email = Email.Create(address);
        Assert.Equal(email.Address, address);
    }
    
    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    public void ShouldFailAnEmail(string address)
    {
        Assert.Throws<InvalidEmailLengthException>(() =>
        {
            var email = Email.Create(address);
        });
    }
    
    [Theory]
    [InlineData("asjkibhdsakjhds")]
    [InlineData("asuoghiudhuds.com@asihusdigyfdgfd")]
    public void ShouldFailToCreateAnEmailIfAddresIsNotValid(string address)
    {
        Assert.Throws<InvalidEmailException>(() =>
        {
            var email = Email.Create(address);
        });
    }
}