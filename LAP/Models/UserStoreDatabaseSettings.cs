using System;
namespace LAP.Models
{
	public class UserStoreDatabaseSettings : IUserStoreDatabaseSettings
	{
        public string CollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}

