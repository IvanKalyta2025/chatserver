using ChatServer.Api.Models;
using Xunit;

namespace MyApp.Tests;

public class UsersTests
{
    [Fact]
    public void Username_SetWithWhitespace_TrimsWhitespace()
    {
        // Arrange
        var user = new Users();

        // Act
        user.Username = "   testuser   ";

        // Assert
        Assert.Equal("testuser", user.Username);
    }
}
