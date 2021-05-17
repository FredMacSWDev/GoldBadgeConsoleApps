using _01_Cafe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe.Repository
{
    public class MenuItemsRepository
    {
        private readonly List<MenuItems> _menuDirectory = new List<MenuItems>();

        public void AddContentToDirectory(MenuItems newContent)
        {
            int startingCount = _menuDirectory.Count;

            _menuDirectory.Add(newContent);

            bool wasAdded = (_menuDirectory.Count > startingCount) ? true : false;
        }
    }
}
