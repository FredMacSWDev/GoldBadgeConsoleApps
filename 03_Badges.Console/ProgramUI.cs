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
        private BadgesRepository _badgeDatabase = new BadgesRepository();
        Dictionary<int, List<string>> badgeAccess = new Dictionary<int, List<string>>();
        public void Run()
        {
            SeedContent();
            Menu();
        }

        private void SeedContent()
        {
            badgeAccess.Add(12345, new List<string> { "A7" });
            badgeAccess.Add(22345, new List<string> { "A1, A4, B1, B2" });
            badgeAccess.Add(32345, new List<string> { "A4" });
        }

        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                System.Console.Clear();
                System.Console.WriteLine("===========================================");
                System.Console.WriteLine("||  Welcome to Komodo Insurance Company  ||");
                System.Console.WriteLine("===========================================");
                System.Console.WriteLine("\nHello Security Admin!\n\nWhat would you like to do?\n\n" +
                    "1) List all badges\n" +
                    "2) Add a badge\n" +
                    "3) Edit a badge\n" +
                    "4) Exit\n");

                string input = System.Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SeeAllBadges();
                        break;

                    case "2":
                        AddBadge();
                        break;

                    case "3":
                        EditBadge();
                        break;
                                            
                    case "4":
                        System.Console.WriteLine("\nThank you for using the Komodo System!\nHave a nice day!\n");
                        keepRunning = false;
                        break;
                    default:
                        System.Console.Write("The number you entered could not be found.\nPlease enter a valid number:");
                        break;
                }

                //System.Console.WriteLine("\nPlease press any key to continue...");
                //System.Console.ReadLine();
                System.Console.Clear();
            }
        }

        public void SeeAllBadges()
        {
            Dictionary<int, List<string>> BadgeData = _badgeDatabase.SeeAllBadges();

            foreach (KeyValuePair<int, List<string>> badge in BadgeData)
            {
                System.Console.WriteLine($"Badge #: {badge.Key}");
                foreach (string doorAccess in badge.Value)
                {
                    System.Console.WriteLine(doorAccess);
                }
            }
            System.Console.WriteLine("\nPress Enter to return to the Main Menu...");
            System.Console.ReadLine();
            Menu();
        }

        public void AddBadge()
        {
            System.Console.Clear();
            Badges addBadge = new Badges();

            System.Console.Write("What is the number on the badge that you would like to add?:  ");
            addBadge.BadgeID = int.Parse(System.Console.ReadLine());

            System.Console.Write("\nPlease enter a door that this badge needs access to:  ");
            System.Console.ReadLine();
            addBadge.Doors.Add(System.Console.ReadLine());

            bool yes = true;

            System.Console.Write($"This door was successfully added to Badge #{addBadge.BadgeID}\n" +
                $"\nAre there any other doors Badge #{addBadge.BadgeID} needs access to (y/n)?\n");


            while (yes)
            {
                string input = System.Console.ReadLine();
                switch (input)
                {
                    case "y":
                        System.Console.WriteLine("\nPlease enter a door that this badge needs access to: ");
                        addBadge.Doors.Add(System.Console.ReadLine());
                        break;

                    case "n":
                        yes = false;
                        break;
                }
            }

            _badgeDatabase.AddBadge(addBadge);
            //System.Console.WriteLine($"\nPlease press any key to continue...");
            //System.Console.ReadKey();
            System.Console.Clear();


        }

        public void EditBadge()
        {
            System.Console.Clear();
            Badges editBadge = new Badges();

            System.Console.Write("What is the badge number that you would like to update?:  ");
            editBadge.BadgeID = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"Badge #{editBadge.BadgeID} has access to doors A5 & A7...\n" +
                $"\nWhat would you like to do?\n" +
                $"1) Remove a door\n" +
                $"2) Add a door\n" +
                $"3) Return to the Main Menu");

            string input = System.Console.ReadLine();

            switch (input)
            {
                case "1":
                    RemoveDoorAccess(editBadge.BadgeID);
                    break;

                case "2":
                    AddDoorAccess(editBadge.BadgeID);
                    break;

                case "3":
                    Menu();
                    break;
            }
        }
        public void RemoveDoorAccess(int badgeID)
        {
            System.Console.WriteLine("\nPlease enter the door to be removed:\n");
            string door = System.Console.ReadLine();
            _badgeDatabase.RemoveBadge(badgeID, door);
            System.Console.WriteLine($"\nAccess to Door #{door} is no longer active.\n");
            System.Console.WriteLine("Please press 'Enter' to return to the Main Menu...");
            System.Console.ReadLine();
            Menu();
        }

        public void AddDoorAccess(int badgeID)
        {
            System.Console.WriteLine("\nPlease enter the door to be removed:\n");
            string door = System.Console.ReadLine();
            _badgeDatabase.EditBadge(badgeID, door);
            System.Console.WriteLine($"\nAccess to Door #{door} is no longer active.\n");
            System.Console.WriteLine("Please press 'Enter' to return to the Main Menu...");
            System.Console.ReadLine();
            Menu();
        }


        //public void RemoveBadge()
        //{
        //    System.Console.Clear();
        //    Badges removeBadge = new Badges();

        //    System.Console.Write("What is the number on the badge that you would like to remove?:  ");
        //    removeBadge.BadgeID = int.Parse(System.Console.ReadLine());

        //    System.Console.Write("\nPlease enter a door from which this badge needs access removed:  ");
        //    System.Console.ReadLine();
        //    removeBadge.Doors.Remove(System.Console.ReadLine());

        //    bool yes = true;

        //    System.Console.Write($"This door was successfully removed to Badge #{removeBadge.BadgeID}\n" +
        //        $"\nAre there any other doors Badge #{removeBadge.BadgeID} needs access to (y/n)?\n");


        //    while (yes)
        //    {
        //        string input = System.Console.ReadLine();
        //        switch (input)
        //        {
        //            case "y":
        //                System.Console.WriteLine("\nPlease enter a door that this badge needs access to: ");
        //                removeBadge.Doors.Add(System.Console.ReadLine());
        //                break;

        //            case "n":
        //                yes = false;
        //                break;
        //        }
        //    }

        //    _badgeDatabase.AddBadge(removeBadge);
        //    //System.Console.WriteLine($"\nPlease press any key to continue...");
        //    //System.Console.ReadKey();
        //    System.Console.Clear();

        }
    }

