using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.Models
{
    //karl
    class User
    {
        static int incrementer = 100;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        

        /// <summary>
        /// auto increments user_Id
        /// </summary>
        /// <param name="name"></param>
        public User(string name)
        {
            Name = name;
            Id = incrementer++;
        }
        


    }
}
