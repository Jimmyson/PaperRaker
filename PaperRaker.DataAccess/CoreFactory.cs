using System.Data.Common;
using System.Data.SQLite;
using NPoco;
using NPoco.FluentMappings;

namespace PaperRaker.DataAccess
{
    public static class CoreFactory
    {
        public static DatabaseFactory DbFactory { get; set; }

        public static void Setup()
        {
            //SQLiteConnection.CreateFile("Data.sqlite");
            var fluentConfig = FluentMappingConfiguration.Configure(new CoreMapping());

            SQLiteConnection conn = new SQLiteConnection("Data Source=Data.sqlite");
            Database db = new Database(conn, DatabaseType.SQLite);
            
            DbFactory = DatabaseFactory.Config(x =>
            {
                x.UsingDatabase(() => db);
                x.WithFluentConfig(fluentConfig);
                conn.Open();
            });

            DbFactory.Build(db);
        }
    }
}