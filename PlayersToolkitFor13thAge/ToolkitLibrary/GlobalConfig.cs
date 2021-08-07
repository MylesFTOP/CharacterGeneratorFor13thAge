using System;
using System.Collections.Generic;
using System.Configuration;

namespace ToolkitLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = Factory.CreateDataConnectionList();

        public static void InitialiseConnections(bool database, bool textfile) {
            if (database) {
                // TODO: Add database connection details
                SQLConnector sql = Factory.CreateSqlConnector();
                Connections.Add(sql);
            }
        }

        public static string GetSetting (string key) {
            var value = Environment.GetEnvironmentVariable(key);

            if (string.IsNullOrEmpty(value)) {
                value = ConfigurationManager.AppSettings[key];
            }

            return value;
        }
    }
}
