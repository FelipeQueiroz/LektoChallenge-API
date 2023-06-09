﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace LAP.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("cpf")]
        public string Cpf { get; set; } = String.Empty;

        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;

        [BsonElement("address")]
        public Address[]? Address { get; set; }

        [BsonElement("cellphone")]
        public string Cellphone { get; set; } = String.Empty;

        [BsonElement("password")]
        public string Password { get; set; } = String.Empty;
    }
}

