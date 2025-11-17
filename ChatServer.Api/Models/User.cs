using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Api.Models
{

    public class Users
    {
        private string? username; // Backing field for Username property
        public int Id { get; set; }
        public string? PasswordHash { get; set; }
        public string? Username
        {
            get => username;
            set => username = value?.Trim(); // Trim whitespace from the username
        }
    }
}
