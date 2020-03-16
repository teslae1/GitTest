using GitTest.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.Presentations
{
    class PCreateUser
    {
        CCreateUserController controller = new CCreateUserController();
        public void RunCreate()
        {
            Console.WriteLine("Opret brugere, tryk -1 for afslut");
            string indtastet = string.Empty;
            do
            {
                Console.Write("Bruger Navn: ");
                 indtastet = Console.ReadLine();
                controller.CreateUser(indtastet);



            } while (indtastet != "-1");
        }


    }
}
