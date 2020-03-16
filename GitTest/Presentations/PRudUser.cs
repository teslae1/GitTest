using GitTest.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.Presentations
{
    class PRudUser
    {
        CRudUserController controller = new CRudUserController();
        public void RunCreate()
        {
            Console.WriteLine("RUD Bruger menu:");
            Menu();
            int.TryParse(Console.ReadLine(), out int indtastet);
            do
            {
                switch (indtastet)
                {
                    case 1:
                        Console.WriteLine("Tast id");
                        var user = controller.GetSpecificUser(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine($"{user.Id} - {user.Name}");
                        break;
                    case 2:
                        var userListe = controller.GetAll();
                        foreach(var obj in userListe)
                        {
                            Console.WriteLine($"{obj.Id} - {obj.Name}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Tast id");
                        controller.DeleteSpecificUser(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Nyt navn:");
                        var navn = Console.ReadLine();
                        int.TryParse(Console.ReadLine(), out int id);
                        controller.UpdateUser(id, navn); 
                        break;
                }


                int.TryParse(Console.ReadLine(), out indtastet);


            } while (indtastet != -1);
        }

        private void Menu()
        {
            Console.WriteLine("1. Get specifik user med id");
            Console.WriteLine("2. Get all users");
            Console.WriteLine("3. Slet specifik user med ID");
            Console.WriteLine("4. Update specifik user med id");



        }
    }
}
