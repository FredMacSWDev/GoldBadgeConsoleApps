using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe.Repository
{
    //public enum IngredientsBin 
    //{ 
    //    CoffeeBeans = 1, 
    //    Milk, 
    //    WhippedCream, 
    //    Espresso, 
    //    ChocolateSyrup, 
    //    VanillaSyrup, 
    //    CaramelSyrup, 
    //    ShavedChocolate, 
    //    Cinnamon 
    //}
    public enum MenuItem 
    { 
        Coffee = 1, 
        Decaf, 
        Espresso, 
        CafeAuLait, 
        Macchiato, 
        Latte, 
        Breve, 
        Mocha,
        OrangeJuice,
        Milk,
        Donuts, 
        Bagels, 
        EnglishMuffins, 
        EggCheeseBiscuit,
        HashBrowns,
        Pancakes,
        Waffles,
        Eggs,
        Bacon,
        Ham
    }
    public class MenuItems
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public MenuItem Ingredients { get; set; }
        public double Price { get; set; }


        public MenuItems() { }
        public MenuItems(int mealNumber, string mealName, string description, MenuItem ingredients, double price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;

        }
    }
}
