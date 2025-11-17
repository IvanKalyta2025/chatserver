using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Api.Models
{
    public class Chatroominfo
    {
        public int IdChat { get; set; } //уникальный идентификатор чата
        public int User1Id { get; set; } //первый пользователь в чате
        public int User2Id { get; set; } //второй пользователь в чате

    }
}