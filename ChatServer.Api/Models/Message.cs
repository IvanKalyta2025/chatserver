using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Api.Models
{
    public class Message
    {
        public int ChatId { get; set; } //идентификатор чата - связь с Chatroominfo
        public int IdMessage { get; set; } //уникальный идентификатор сообщения
        public int SenderId { get; set; } //тот кто отправляет сообщение
        public int ReceiverId { get; set; } //тот кто получает сообщение
        public string? Text { get; set; } //текст сообщения
        public int TimeInChat { get; set; } = (int)DateTimeOffset.UtcNow.ToUnixTimeSeconds(); //время отправки сообщения в секундах

    }
}