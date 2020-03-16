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

        }

        public bool Create(User user)
        {
            bool wasSuccess = foundation.Create(user);

            if(wasSuccess)
            {
                users.Add(user);
            }
        }
    }
}
