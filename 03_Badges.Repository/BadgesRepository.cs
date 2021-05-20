using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges.Repository
{
    public class BadgesRepository
    {
        public Dictionary<int, List<string>> _badgeAccess = new Dictionary<int, List<string>>();
        //public void AddBadges(Badges badgeID) => _badgeDatabase.Add(badgeID);

        public Dictionary<int, List<string>> SeeAllBadges()
        {
            return _badgeAccess;
        }

        public void AddBadge(Badges badges)
        {
            _badgeAccess.Add(badges.BadgeID, badges.Doors);
        }

        public void EditBadge(int badgeID, string doors)
        {
            List<string> doorsAccess = _badgeAccess[badgeID];
            doorsAccess.Add(doors);
        }

        public void RemoveBadge(int badgeID, string doors)
        {
            List<string> doorsAccess = _badgeAccess[badgeID];
            doorsAccess.Remove(doors);
        }
    }
}
