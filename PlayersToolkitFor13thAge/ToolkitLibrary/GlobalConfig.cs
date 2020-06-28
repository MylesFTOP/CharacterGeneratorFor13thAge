using System.Collections.Generic;

namespace ToolkitLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitialiseConnections(bool database, bool textfile) {
            if (database) {
                // TODO: Add database connection details
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (textfile) {
                // TODO: Add textfile connection details
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
