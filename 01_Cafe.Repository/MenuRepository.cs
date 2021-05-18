using _01_Cafe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe.Repository
{
    public class MenuRepository
    {
        private readonly List<MenuItems> _menuDirectory = new List<MenuItems>();

        public void AddContentToDirectory(MenuItems content)
        {
            int startingCount = _menuDirectory.Count;

            _menuDirectory.Add(content);

            bool wasAdded = (_menuDirectory.Count > startingCount) ? true : false;
        }

        public List<MenuItems> GetContentList()
        {
            return _menuDirectory;
        }

        public bool UpdateExistingContent(string originalMenuItem, MenuItems newContent)
        {
            MenuItems oldContent = GetContentByMealName(originalMenuItem);

            if(oldContent != null)
            {
                oldContent.MealNumber = newContent.MealNumber;
                oldContent.MealName = newContent.MealName;
                oldContent.Description = newContent.Description;
                oldContent.Ingredients = newContent.Ingredients;
                oldContent.Price = newContent.Price;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveContentFromList(string mealName)
        {
            MenuItems content = GetContentByMealName(mealName);

            if(content == null)
            {
                return false;
            }

            int initialCount = _menuDirectory.Count;
            _menuDirectory.Remove(content);

            if(initialCount > _menuDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public MenuItems GetContentByMealName(string mealName)
        {
            foreach(MenuItems content in _menuDirectory)
            {
                if(content.MealName == mealName)
                {
                    return content;
                }
            }

            return null;
        }
    }
}
