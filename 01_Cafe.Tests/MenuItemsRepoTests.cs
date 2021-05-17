using _01_Cafe.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Cafe.Tests
{
    [TestClass]
    public class MenuItemsRepoTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBool()
        {
            MenuItems menu = new MenuItems();
            MenuItemsRepository repo = new MenuItemsRepository();

            bool addResult = repo.AddContentToDirectory(menu);

            Assert.IsTrue(addResult);
        }
    }
}
