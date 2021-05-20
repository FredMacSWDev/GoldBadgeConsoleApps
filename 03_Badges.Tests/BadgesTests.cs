using _03_Badges.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_Badges.Tests
{
    [TestClass]
    public class BadgesTests
    {
        private BadgesRepository _badgeDatabase;
        private Dictionary<int, List<string>> badgeAccess;

        [TestMethod]
        public void Arrange()
        {
            _badgeDatabase = new BadgesRepository();
            badgeAccess = new Dictionary<int, List<string>>();
        }

        [TestMethod]
        public void SeeAllBadges_ShouldListBadges()
        {
            Dictionary<int, List<string>> dictionary = _badgeDatabase.SeeAllBadges();
        }
    }
}
