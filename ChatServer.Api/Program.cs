using System;
using System.Collections.Generic;

namespace ChatServer.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ChatServer API is running...");

            var user = new Models.Users();
            user.Username = "   exampleUser   ";
            Console.WriteLine($"Trimmed Username: '{user.Username}'");
        }
    }
}

