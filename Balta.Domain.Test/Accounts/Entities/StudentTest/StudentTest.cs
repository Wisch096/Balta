using Balta.Domain.Accounts.Entities;

namespace Balta.Domain.Tests.Accounts.Entities.StudentTest;

public class StudentTest
{
    [Fact]
    public void Test1()
    {
        var student = new Student("Matheus", "Wisch", "wisch.dev@gmail.com");
    }
} 