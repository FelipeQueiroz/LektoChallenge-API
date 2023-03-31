﻿using System;
using LAP.Models;
using MongoDB.Driver;

namespace LAP.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IUserStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<User>(settings.CollectionName);
        }
        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }
        public User Login(string email, string password)
        {
            return _users.Find(u => u.Email == email && u.Password == password).FirstOrDefault();
        }

        public List<User> Get()
        {
            return _users.Find(user => true).ToList();
        }

        public User Get(string id)
        {
            return _users.Find(user => user.Id == id).FirstOrDefault();
        }

        public User GetByEmail(string email)
        {
            return _users.Find(user => user.Email == email).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _users.DeleteOne(user => user.Id == id);
        }

        public void Update(string id, User user)
        {
            _users.ReplaceOne(user => user.Id == id, user);
        }
    }
}

