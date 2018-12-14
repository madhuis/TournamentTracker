using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        // Equivalent to = new List<Person>();
        //public TeamModel()
        //{
        //    TeamMembers = new List<Person>();
        //}

        public string TeamName { get; set; }
    }
}
