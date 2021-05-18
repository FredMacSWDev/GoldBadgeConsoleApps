using _01_Cafe.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Cafe.Tests
{
    [TestClass]
    public class MenuRepoTests
    {
        private MenuRepository _repo;
        private MenuItems _menu;

        [TestInitialize]

        public void Arrange()
        {
            _menu = new MenuItems();
            _repo = new MenuRepository();

            _repo.AddContentToDirectory(_menu);
        }

        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            MenuItems content = new MenuItems();
            content.MealName = "Coffee & Donuts";
            MenuRepository repo = new MenuRepository();

            repo.AddContentToDirectory(content);
            MenuItems contentFromMenuList = repo.GetContentByMealName("Coffee & Donuts");

            Assert.IsNotNull(contentFromMenuList);
        }

        [TestMethod]
        public void UpdateExistingMenuItems()
        {
            MenuItems content = new MenuItems();

            bool updateResult = _repo.UpdateExistingContent("Coffee & Donuts", content);

            Assert.IsFalse(updateResult);
        }
        [DataTestMethod]
        public void UpdateExistingContent_ShouldMatchBool()
        {

        }

    }
}
