using _01_Cafe.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe.Console
{
    public class ProgramUI
    {
        private readonly MenuRepository _repo = new MenuRepository();
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
            System.Console.Clear();
            List<MenuItems> allMenuItems = _repo.GetContentList();
            DataTable cafeMenu = new DataTable("Komodo Café Database");
            System.Console.WriteLine(string.Format("{0," + ((System.Console.WindowWidth / 2) + (cafeMenu.TableName.Length / 2)) + "}", cafeMenu));
            DataColumn mealNum = new DataColumn("Meal Number", typeof(int));
            DataColumn mealName = new DataColumn("Meal Name", typeof(Enum));
            DataColumn mealDesc = new DataColumn("Description", typeof(string));
            DataColumn mealIngredients = new DataColumn("Meal Ingredients", typeof(string));
            DataColumn mealPrice = new DataColumn("Price", typeof(string));
            cafeMenu.Columns.Add(mealNum);
            cafeMenu.Columns.Add(mealName);
            cafeMenu.Columns.Add(mealDesc);
            cafeMenu.Columns.Add(mealIngredients);
            cafeMenu.Columns.Add(mealPrice);
            DataRow mealNumRow;

            foreach (MenuItems idPrint in allMenuItems)
            {
                mealNumRow = cafeMenu.NewRow();
                mealNumRow["Meal Number"] = idPrint.MealNumber;
                mealNumRow["Meal Name"] = idPrint.MealName;
                mealNumRow["Description"] = idPrint.Description;
                mealNumRow["Meal Ingredients"] = idPrint.Ingredients;
                mealNumRow["Price"] = idPrint.Price.ToString("C2");
                cafeMenu.Rows.Add(mealNumRow);
            }
            PrintDataTable(cafeMenu);
            System.Console.WriteLine();
        }

        private void PrintDataTable(DataTable cafeMenu)
        {

            System.Console.WriteLine("{0, 8}\t{1, 1}\t{2, 5}\t{3, 17}\t{4, 2}\t{5, 0}\t{6, 0}",
                "Meal Number",
                "Meal Name",
                "Description",
                "Meal Ingredients",
                "Price",
                );

            foreach (DataRow row in cafeMenu.Rows)
            {
                System.Console.WriteLine("{0, 8}\t{1, 1}\t{2, 5}\t{3, 9}\t{4, 2}\t{5, 18}\t{6, 8}",
                row["Meal Number"],
                row["Meal Name"],
                row["Description"],
                row["Meal Ingredients"],
                row["Price"]
            }
        }
        private void AddNewMenuItem()
        {
            MenuItems newMenuItems = new MenuItems();

            System.Console.WriteLine("Please enter the new Meal Number:");
            string menuNumAsString = System.Console.ReadLine();
            int menuNumAsInt = Convert.ToInt32(menuNumAsString);
            newMenuItems.MealNumber = (MenuItem)menuNumAsInt;

            System.Console.WriteLine("Please enter the new Meal Name:");
            newMenuItems.MealName = System.Console.ReadLine();

            System.Console.WriteLine("Please enter a description of this meal:");
            newMenuItems.Description = System.Console.ReadLine();

            System.Console.WriteLine("Please enter the ingredients for this meal:");
            string menuIngAsString = System.Console.ReadLine();
            newMenuItems.Ingredients = menuIngAsString;

            System.Console.WriteLine("Please enter the price of this meal:");
            string priceAsString = System.Console.ReadLine();
            newMenuItems.Price = double.Parse(priceAsString);
        }

        private void UpdateExistingMenu()
        {

        }

        private void DeleteExistingMenuItem()
        {

        }
    }
}
