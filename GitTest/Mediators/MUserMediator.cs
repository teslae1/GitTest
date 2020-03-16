using GitTest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using GitTest.Foundations;

namespace GitTest.Mediators
{
    class MUserMediator
    {
        List<User> users = new List<User>();
        FUserFoundation foundation = new FUserFoundation();

        public MUserMediator()
        {
            users = foundation.GetAll();
        }

        public User Read(int userId)
        {
            User selectedUser = null;
            foreach(User u in users)
            {
                if(u.Id == userId)
                {
                    selectedUser = u;
                }
            }

            return selectedUser;
        }

        public List<User> ReadAll()
        {
            return users;
        }

        public bool Create(User user)
        {
            bool wasSuccess = foundation.Create(user);

            if(wasSuccess)
            {
                users.Add(user);
            }

            return wasSuccess;
        }

        public bool Update(User user)
        {
            bool wasSuccess = foundation.Update(user);

            if(wasSuccess)
            {
                for(int i = 0; i < users.Count; i++)
                {
                    if(users[i].Id == user.Id)
                    {
                        users[i] = user;
                        return wasSuccess;
                    }
                }
            }
            return wasSuccess;
        }

        public bool Delete(User userToDelete)
        {
            bool wasSuccess = foundation.Delete(userToDelete);

            if(wasSuccess)
            {
                users.Remove(userToDelete);
            }

            return wasSuccess;
        }
    }
}
