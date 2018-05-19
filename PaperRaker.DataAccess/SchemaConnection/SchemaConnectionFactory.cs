using System.Data.SQLite;
using NPoco;

namespace PaperRaker.DataAccess.SchemaConnection
{
    public static class SchemaConnectionFactory
    {
        public static IDatabase CreateSchemaConnection(string schema)
        {
            switch (schema.ToUpper())
            {
                case "CORE":
                    return new CoreSchemaConnection().Setup(new SQLiteConnection("Data Source=Data.sqlite"));
                case "FUNDING":
                    return new FundingSchemaConnection().Setup(new SQLiteConnection("Data Source=Funding.sqlite"));
                default:
                    return null;
            }
        }
    }
}