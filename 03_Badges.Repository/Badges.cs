using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges.Repository
{
    public class Badges
    {
        public int BadgeID { get; set; }
        public List<string> Doors { get; set; }

        public Badges() { }

        public Badges(int badgeID, List<string> doors)
        {
            BadgeID = badgeID;
            Doors = doors;
        }

    }
}
