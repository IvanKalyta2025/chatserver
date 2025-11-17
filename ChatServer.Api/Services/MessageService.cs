using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Api.Services
{
    public class MessageService
    {
        readonly List<Models.Message> _messages = new(); //хранилище сообщений

        public void AddMessage(Models.Message message)
        {
            _messages.Add(message); //добавление сообщения в хранилище
        }


    }
}