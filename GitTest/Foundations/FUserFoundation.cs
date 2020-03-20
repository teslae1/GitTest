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

        public bool Create(User userToCreate)
        {
            if (!ContainsUser(userToCreate))
            {
                users.Add(userToCreate);
                return true;
            }
            else
                return false;
        }
        public bool Update(User userToUpdate)
        {
            var updated = new User(userToUpdate.Id, userToUpdate.Name);

            for (int i = 0; i < users.Count; i++)
                if (users[i].Id == userToUpdate.Id)
                {

                    users[i] = updated;
                    return true;
                }


            return false;
        }
        public bool Delete(User userToDelete)
        {
            for (int i = 0; i < users.Count; i++)
                if (users[i].Id == userToDelete.Id)
                {
                    users.RemoveAt(i);
                    return true;
                }


            return false;
        }
        public User GetById(int id)
        {
            foreach (User user in users)
                if (user.Id == id)
                    return user;


            return null;
        }


         bool ContainsUser(User user)
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
