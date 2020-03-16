using GitTest.Mediators;
using GitTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.Controllers
{
    class CCreateUserController
    {
        MUserMediator m = new MUserMediator();
        public void CreateUser(string name)
        {
            var user = new User(name);
            m.Create(user);
        }
    }
}
