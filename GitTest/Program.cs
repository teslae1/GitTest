using GitTest.Presentations;
using System;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast for at navigere i menu");
            Console.WriteLine("Tryk -1 for at afslutte");
            Menu();
            int.TryParse(Console.ReadLine(), out int Indtastet);
            do {
                Menu();
                int.TryParse(Console.ReadLine(), out Indtastet);
                switch (Indtastet)
                {
                    case 1:
                        var createView = new PCreateUser();
                        break;
                    case 2:
                        var rudView = new PRudUser();
                        break;
                }
            
            
            } while (Indtastet != -1);
        }

        private static void Menu()
        {
            Console.WriteLine("1. Create User");
            Console.WriteLine("2. RUD User");
        }
    }
}
