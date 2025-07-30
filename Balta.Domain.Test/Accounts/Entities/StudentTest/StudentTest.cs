using Balta.Domain.Accounts.Entities;
using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Shared.Abstractions;
using Balta.Domain.Tests.Mocks;

namespace Balta.Domain.Tests.Accounts.Entities.StudentTest;

public class StudentTest
{
    private readonly IDateTimeProvider _dateTimeProvider = new FakeDateTimeProvider();
    
    [Fact]
    public void ShouldRaiseOnStudentCreatedEventPrimitive()
    {
        var student = Student.Create("Matheus", "Wisch", "wisch@gmailok.com", _dateTimeProvider);
        Assert.Single(student.Events);
    }
    
    [Fact]
    public void ShouldRaiseOnStudentCreatedEvent()
    {
        var name = Name.Create("André", "Wisch");
        var email = Email.Create("teteu@gmasil.com");
        var student = Student.Create(name, email, _dateTimeProvider);
        Assert.Single(student.Events);
    }
} 