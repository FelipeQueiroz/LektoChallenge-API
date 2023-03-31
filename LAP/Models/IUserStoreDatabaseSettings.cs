using System;
namespace LAP.Models
{
	public interface IUserStoreDatabaseSettings
	{
		string CollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}

