using System;
using MongoDB.Bson.Serialization.Attributes;

namespace LAP.Models
{
	public class Address
	{
        [BsonElement("street")]
        public string Street { get; set; } = String.Empty;

        [BsonElement("city")]
        public string City { get; set; } = String.Empty;

        [BsonElement("state")]
        public string State { get; set; } = String.Empty;
    }
}

