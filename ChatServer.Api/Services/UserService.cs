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
        //https://dev.to/dianaiminza/linq-first-and-firstordefault-methods-in-c-o4c

        public Models.Users? GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username); //поиск пользователя по имени
        }

        public Models.Users? GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id); //поиск пользователя по идентификатору
        }

        public bool CheckUserExists(string username)
        {
            return _users.Any(u => u.Username == username); //проверка существования пользователя Any() сам проверяет на true/false

            //вернуть ошибку если пользователь существует при регистрации
        }
        public void CheckUserExistsOrFail(string username)
        {
            if (_users.Any(u => u.Username == username))
            {
                throw new Exception("User already exists"); //генерация ошибки если пользователь существует
            }
        }

    }
}