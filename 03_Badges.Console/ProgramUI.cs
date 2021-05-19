using _03_Badges.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges.Console
{
    public class ProgramUI
    {
        private BadgesRepository _repo = new BadgesRepository();
        public Dictionary<int, List<string>> keyAndValue = new Dictionary<int, List<string>>();
        public void Run()
        {
            SeedContent();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                System.Console.Clear();
                System.Console.WriteLine("Komodo Insurance Company");
                System.Console.WriteLine("Hello Security Admin!\n\nWhat would you like to do?\n" +
                    "1) Add a badge\n" +
                    "2) Edit a badge\n" +
                    "3) List all badges\n" +
                    "4) Exit\n");

                string input = System.Console.ReadLine();

                switch (input)
                {
                    case "1":                        
                            AddBadge();
                            break;

                    case "2":
                        EditBadge();
                        break;

                    case "3":
                        SeeAllBadges();
                        break;

                    case "4":
                        System.Console.WriteLine("\nThank you for using the Komodo System!\nHave a nice day!\n");
                        keepRunning = false;
                        break;
                    default:
                        System.Console.WriteLine("Please enter a valid number:");
                        break;
                }

                System.Console.WriteLine("Please press any key to continue...");
                System.Console.ReadKey();
                System.Console.Clear();
            }
        }

        private void AddBadge()
        {
            Badges addBadge = new Badges();
            addBadge.Doors = new List<string>();

            System.Console.Clear();
            System.Console.WriteLine("What is the number on the badge?\n");
            addBadge.BadgeID = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Please list a door that it needs access to:\n");
            addBadge.Doors.Add(System.Console.ReadLine());

            bool yes = true;
            System.Console.WriteLine($"This door was successfully add to Badge #{addBadge.BadgeID)");
        }

        private void EditBadge()
        {

        }

        private void SeeAllBadges()
        {

        }

        private void SeedContent()
        {
            _repo.Add(12345, "A7");
            _repo.Add(22345, "A1, A4, B1, B2");
            _repo.Add(32345, "A4");
        }
    }
}
