using System;
namespace LAP.Models
{
    public interface IMessageStoreDatabaseSettings
    {
        string CollectionMessageName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

