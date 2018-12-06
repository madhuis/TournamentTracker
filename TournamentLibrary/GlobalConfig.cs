using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public static class GlobalConfig
    {
        // We can save data connections and/or Text files that is why we used List here.
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database) // true value => database == true
            {
                // TODO = Create a Sql connection
            }

            if (textFiles)
            {
                // TODO = Create a Text Connection
            }
        }

        
    }
}
