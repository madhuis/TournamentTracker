using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the MatchUp
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents scores from the particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the Matchup that this team came from the Winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore">
        /// 
        /// </param>
        public MatchupEntryModel(double initialScore)
        {

        }
    }
}
