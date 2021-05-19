using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges.Repository
{
    public class BadgesRepository
    {
        private Dictionary<int, List<string>> _badgeDatabase = new Dictionary<int, List<string>>();
        public void AddBadges(Badges badgeID) => _badgeDatabase.Add(badgeID);

        private void EditBadge()
        {

        }

        private void SeeAllBadges()
        {

        }
    }
}
