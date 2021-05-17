using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe.Repository
{
    public enum IngredientsBin { Coffee, Milk, WhippedCream, Espresso, ChocolateSyrup, VanillaSyrup, CaramelSyrup, ShavedChocolate, Cinnamon }
    public enum MenuItem { Coffee, DecafCoffee, Espresso, CafeAuLait, Macchiato, Latte, Breve, Mocha, Donuts, Bagels, EnglishMuffins, EggCheeseBiscuit }
    public class MenuItems
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public IngredientsBin Ingredients { get; set; }
        public double Price { get; set; }


        public MenuItems() { }
        public MenuItems(int mealNumber, string mealName, string description, IngredientsBin ingredients, double price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;

        }
    }
}
