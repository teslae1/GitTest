using System;
using System.Collections.Generic;
using System.Text;
using GitTest.Mediators;
using GitTest.Models;

namespace GitTest.Controllers
{
    class CCreateUserController
    {
        MUserMediator m = new MUserMediator();
        public void CreateUser(string navn)
        {
            var user = new User(navn);
            m.Create(user);
        }
    }
}
