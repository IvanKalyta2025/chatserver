using ChatServer.Api.Models;

namespace ChatServer.Api.Services
{
    public class MessageService
    {
        readonly List<Message> _messages = new(); //хранилище сущности 

        public void AddMessage(Message message)
        {
            _messages.Add(message); //добавление сущности в хранилище
        }

        public List<Message> GetMessagesByChatId(int ChatId)
        {
            return _messages
            .Where(m => m.ChatId == ChatId)
            .OrderBy(m => m.TimeInChat)
            .ToList(); //поиск сущности по идентификатору чата
        }
        public void AddMessageChat(Message msg)
        {
            if (string.IsNullOrWhiteSpace(msg.Text))
                throw new Exception("Сообщение пустое");

            if (msg.Text.Length > 500)
                throw new Exception("Сообщение слишком длинное");

            _messages.Add(msg);
        }
    }
}
