using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRaces
{
    internal class BigRacesShow
    {
        readonly List<Interface1> gamesList = new List<Interface1>();
        readonly List<Team> teamList = new List<Team>();

        internal static void StartShow(Mousetrap mousetrap)
        {
            throw new NotImplementedException();
        }

        internal static void StartShow(Fishing fishing)
        {
            throw new NotImplementedException();
        }

        internal static void StartShow(Slide slide)
        {
            throw new NotImplementedException();
        }

        internal static void StartShow(Postmen postmen)
        {
            throw new NotImplementedException();
        }

        internal static void StartShow(Sea sea)
        {
            throw new NotImplementedException();
        }

        internal static void StartShow(Beach beach)
        {
            throw new NotImplementedException();
        }

        internal static void StartShow(Chess chess)
        {
            throw new NotImplementedException();
        }

        public void AddGames(Interface1 game)
        {
            gamesList.Add(game);
        }
        public void AddToTeam(Team team)
        {
            teamList.Add(team);
        }
        public void StartBigRaces(Interface1 game)
        {
            game.StartGames();
        }
    }
}
