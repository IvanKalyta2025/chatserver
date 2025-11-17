using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Api.Services
{
    public class UserService
    {
        readonly List<Models.Users> _users = new(); //хранилище пользователей
        public void AddUser(Models.Users user)
        {
            _users.Add(user); //добавление пользователя в хранилище
        }

    }
}