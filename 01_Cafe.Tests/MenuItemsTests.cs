using _01_Cafe.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Cafe.Tests
{
    [TestClass]
    public class MenuItemsTests
    {
        [TestMethod] 
        public void SetMenuItem_ShouldSetCorrectMenuItem()
        {
            MenuItems content = new MenuItems();
            content.MealName = "Coffee & Donuts";
            string expected = "Coffee & Donuts";
            string actual = content.MealName;

            Assert.AreEqual(expected, actual);
        }
    }
}
