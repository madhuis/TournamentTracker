using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make the createPrize Method actually save the database
        /// <summary>
        /// Saves a new Prize to the database
        /// </summary>
        /// <param name="model">The Prize Information</param>
        /// <returns>The Prize Info, Including the Unique Identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;

        }
    }
}
