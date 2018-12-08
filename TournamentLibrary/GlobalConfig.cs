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
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>(); // It will hold anything that has IDataConnection Contract.

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database) // true value => database == true
            {
                // TODO = Create a Sql connection
                //TODO = Set up the Sql Connector Properly
                SqlConnector sql = new SqlConnector();  // SqlConnector - Connects to the Sql
                Connections.Add(sql);

            }

            if (textFiles)
            {
                // TODO = Create a Text Connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }

        
    }
}
