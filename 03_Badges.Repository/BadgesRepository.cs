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

        public bool AddBadge(Badges badges)
        {
            int startCount = _badgeAccess.Count;
            _badgeAccess.Add(badges.BadgeID, badges.Doors);
            bool wasAdded = (_badgeAccess.Count > startCount) ? true : false;
            return wasAdded;
        }

        public void EditBadge(int badgeID, string doors)
        {
            List<string> doorsAccess = _badgeAccess[badgeID];
            doorsAccess.Add(doors);
        }

        public List<string> RemoveBadge(int badgeID, string doors)
        {
            List<string> doorsAccess = _badgeAccess[badgeID];
            doorsAccess.Remove(doors);
            return doorsAccess;
        }
    }
}
