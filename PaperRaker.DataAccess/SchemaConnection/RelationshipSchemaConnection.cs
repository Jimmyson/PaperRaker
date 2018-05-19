using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using NPoco;
using PaperRaker.DataAccess.Mapping;

namespace PaperRaker.DataAccess.SchemaConnection
{
    public class FundingSchemaConnection : BaseSchemaConnection
    {
        //public DatabaseFactory DbFactory { get; set; }

        public Database Setup(DbConnection connection)
        {
            if(!File.Exists("Data.sqlite"))
                SQLiteConnection.CreateFile("Funding.sqlite");
            return Setup(new FundingMapping(), connection);
        }
    }
}