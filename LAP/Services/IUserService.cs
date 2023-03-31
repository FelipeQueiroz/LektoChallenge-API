using LAP.Models;
using System;
namespace LAP.Services
{
	public interface IUserService
	{
		List<User> Get();
		User Get(string id);
        User GetByEmail(string email);
        User Login(string email, string password);
        User Create(User user);
		void Update(string id, User user);
		void Remove(string id);
	}
}

