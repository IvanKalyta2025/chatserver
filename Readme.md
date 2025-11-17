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

.IdMassege
.SenderId
.ReceiverId
.Text
.Timeinchat
.ChatId

    Chatroom.cs

.IdChat
.User1
.User2

MAPPE Services

    .MessageService.cs

List \_messages and AddMessage (message)

    .UserService.cs

List \_users and AddUser (user)
GetUserByUsername поиск по имени
GetUserByIfd поиск по ид что бы потом использовать в проперти
CheckUserExists проверяю что есть пользователь или нет и использую bool b cпец меетод Any() который сам возвращает true или false

UnitTest
Program.cs
