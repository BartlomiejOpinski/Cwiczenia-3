using LegacyApp;
using Xunit;

namespace LegacyAppTests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_Should_Return_False_When_Missing_FirstName()
        {
            var service = new UserService();

            var result = service.AddUser(null, null, "kowalski@wp.pl", new DateTime(1980, 8, 18), 1);

            Assert.Equal(false,result);
        }
    
}