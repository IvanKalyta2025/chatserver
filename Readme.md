dotnet new sln -n ChatServer

dotnet new webapi -n ChatServer.Api

dotnet sln add ChatServer.Api/ChatServer.Api.csproj

dotnet new xunit -n MyApp.Tests

dotnet add MyApp.Tests reference ChatServer.Api/ChatServer.Api.csproj

dotnet test

User.cs
.Id
.PasswordHash
.Username .Trim()

Message.cs
.Idchat
.SenderId
.ReceiverId
.Text
.Timeinchat

UnitTest**\_**

Program.cs
