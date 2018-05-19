using System.Data.Common;
using NPoco;
using NPoco.FluentMappings;

namespace PaperRaker.DataAccess.SchemaConnection
{
    public abstract class BaseSchemaConnection
    {
        protected static Database Setup(Mappings mapping, DbConnection connection)
        {
            var fluentConfig = FluentMappingConfiguration.Configure(mapping);
            var db = new Database(connection, DatabaseType.SQLite);
            
            var dbfactory = DatabaseFactory.Config(x =>
            {
                x.UsingDatabase(() => db);
                x.WithFluentConfig(fluentConfig);
                connection.Open();
            });

            dbfactory.Build(db);
            
            return dbfactory.GetDatabase();
        }
    }
}