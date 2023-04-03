using System;
namespace LAP.Models
{
	public class MessageStoreDatabaseSettings : IMessageStoreDatabaseSettings
	{
        public string CollectionMessageName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}

