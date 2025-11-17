using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Api.Models
{
    public class Chatroominfo
    {
        public int IdChat { get; set; } //уникальный идентификатор чата
        public int User1 { get; set; } //первый пользователь в чате
        public int User2 { get; set; } //второй пользователь в чате

    }
}