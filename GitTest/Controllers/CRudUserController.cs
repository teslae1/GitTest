using GitTest.Mediators;
using GitTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.Controllers
{
    class CRudUserController
    {
        MUserMediator m = new MUserMediator();
        
        public List<User> GetAll()
        {
            return m.ReadAll();
        }

        public User GetSpecificUser(int id)
        {
            return m.Read(id);
        }
        public void DeleteSpecificUser(int id)
        {
            var user = GetSpecificUser(id);
            m.Delete(user);
        }

        public void UpdateUser(int id, string navn)
        {
            var obj = GetSpecificUser(id);
            obj.SetName(navn);
            m.Update(obj);

        }
    }
}
