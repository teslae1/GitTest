using System;
using System.Collections.Generic;
using System.Text;
using GitTest.Mediators;

namespace GitTest.Controllers
{
    class CCreateUserController
    {
        MUserMediator m = new MUserMediator();
        public void CreateUser(string navn)
        {
            m.CreateUser()
        }
    }
}
