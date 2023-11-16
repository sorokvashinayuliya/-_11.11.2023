using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRaces
{
    internal class Team
    {
        readonly string Country;
        readonly List<Team> members = new List<Team>();
        public Team(string Country, params Person[] members)
        {
            this.Country = Country;
            foreach (Person player in members)
            {
                this.members.Add(player);
            }
        }
    }
}
