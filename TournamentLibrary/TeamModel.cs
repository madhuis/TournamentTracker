using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public class TeamModel
    {
        public List<Person> TeamMembers { get; set; } = new List<Person>();

        // Equivalent to = new List<Person>();
        //public TeamModel()
        //{
        //    TeamMembers = new List<Person>();
        //}

        public string TeamName { get; set; }
    }
}
