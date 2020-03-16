using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.Controllers
{
    class CCreateUserController
    {
        Mediator m = new Mediator();
        public void CreateUser(string navn)
        {
            m.CreateUser()
        }
    }
}
