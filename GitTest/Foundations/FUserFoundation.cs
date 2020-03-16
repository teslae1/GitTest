using GitTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.Foundations
{
    class FUserFoundation
    {
        List<User> users = new List<User> { new User(1, "karl"), new User(2, "nichlas"), new User(3, "martin") };

        public List<User> GetAll()
        {
            return users;
        }

        public void Create(User userToCreate)
        {
            if (!ContainsUser(userToCreate))
                users.Add(userToCreate);
            else
                throw new FormatException("user already exists");
        }
        public void Update(User userToUpdate)
        {
            //get 
        }

        public User GetById(int id)
        {
            foreach (User user in users)
                if (user.Id == id)
                    return user;


            return null;
        }

        private bool ContainsUser(User user)
        {
            foreach(User u in users)
            {
                if (u.Id == user.Id)
                    return true;
            }
            return false;
        }

    }
}
