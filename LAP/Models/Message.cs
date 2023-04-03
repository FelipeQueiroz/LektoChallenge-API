using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LAP.Models
{
	public class Message
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;

        [BsonElement("cellphone")]
        public string Cellphone { get; set; } = String.Empty;

        [BsonElement("text")]
        public string Text { get; set; } = String.Empty;
    }
}

