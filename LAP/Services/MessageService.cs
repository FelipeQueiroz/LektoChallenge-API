using System;
using LAP.Models;
using MongoDB.Driver;

namespace LAP.Services
{
	public class MessageService : IMessageService
	{
        private readonly IMongoCollection<Message> _messages;

        public MessageService(IMessageStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _messages = database.GetCollection<Message>(settings.CollectionMessageName);
        }
        public Message Create(Message message)
        {
            _messages.InsertOne(message);
            return message;
        }
    }
}

