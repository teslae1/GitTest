using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.Models
{
    class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        
    }
}
