using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Net;
using NPoco;
using NPoco.FluentMappings;

namespace PaperRaker.DataAccess
{
    public static class CoreFactory
    {
        public static DatabaseFactory DbFactory { get; set; }

        public static void Setup()
        {
            if(!File.Exists("Data.sqlite"))
                SQLiteConnection.CreateFile("Data.sqlite");
            var fluentConfig = FluentMappingConfiguration.Configure(new CoreMapping());

            DbConnection connection = new SQLiteConnection("Data Source=Data.sqlite");
            Database db = new Database(connection, DatabaseType.SQLite);
            
            DbFactory = DatabaseFactory.Config(x =>
            {
                x.UsingDatabase(() => db);
                x.WithFluentConfig(fluentConfig);
                connection.Open();
            });

            DbFactory.Build(db);
        }
    }
}