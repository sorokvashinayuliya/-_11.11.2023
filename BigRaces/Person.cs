using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BigRaces
{
    enum PersonPosition
    {
        игрок,
        организатор
    }
    internal class Person
    {
        readonly string personName;
        readonly PersonPosition personPosition;
        public AddingTeam(BigRacesShow tournament, params Teams[] teams)
        {
            if (personPosition== PersonPosition.организатор)
            {
                foreach (Team team in teams)
                {
                    tournament.AddToTeam(team);
                }
            }
        }
        public void AddingGame(BigRacesShow tournament, params Interface1[] games)
        {
            if (personPosition == PersonPosition.организатор)
            {
                foreach (Interface1 game in games)
                {
                    tournament.AddGames(game);
                }
            }
        }
        public Person(string personName, PersonPosition personPosition)
        {
            this.personName = personName;
            this.personPosition = personPosition;
        }
    }
}
