using _01_Cafe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe.Console
{
    public class ProgramUI
    {
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                System.Console.WriteLine("Please select a menu option:\n" +
                    "1) View Menu Items\n" +
                    "2) Add Menu Item\n" +
                    "3) Update Menu Item\n" +
                    "4) Delete Menu Item\n" +
                    "5) Exit\n");

                string input = System.Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayMenuItems();
                        break;
                    case "2":
                        AddNewMenuItem();
                        break;
                    case "3":
                        UpdateExistingMenu();
                        break;
                    case "4":
                        DeleteExistingMenuItem();
                        break;
                    case "5":
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

        private void DisplayMenuItems()
        {

        }
        private void AddNewMenuItem()
        {
            MenuItems newMenuItems = new MenuItems();

            //System.Console.WriteLine("Please enter the new Meal Number:");
            //newMenuItems.MealNumber = System.Console.ReadLine();

            //System.Console.WriteLine("Please enter the new Meal Name:");
            //newMenuItems.MealName = System.Console.ReadLine();

            //System.Console.WriteLine("Please enter a description of this meal:");
            //newMenuItems.Description = System.Console.ReadLine();

            //System.Console.WriteLine("Please enter the ingredients for this meal:");
            //newMenuItems.Ingredients = System.Console.ReadLine();

            //System.Console.WriteLine("Please enter the price of this meal:");
            //string priceAsString = System.Console.ReadLine();
            //newMenuItems.Price = double.Parse(priceAsString);
        }

        private void UpdateExistingMenu()
        {

        }

        private void DeleteExistingMenuItem()
        {

        }
    }
}
