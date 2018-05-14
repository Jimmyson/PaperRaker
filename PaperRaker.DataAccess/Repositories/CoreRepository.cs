using System.Data.SQLite;
using NPoco;

namespace PaperRaker.DataAccess.Repositories
{
    public abstract class CoreRepository
    {
        //public IDatabase Connection => CoreFactory.DbFactory.GetDatabase();
        
        /*private SQLiteConnection connectionString;
        public CoreRepository()
        {
            connectionString = new SQLiteConnection("Data Source=Data.sqlite");
        }
 
        public IDatabase Connection
        {
            get
            {
                return new Database(connectionString, DatabaseType.SQLite);
            }
        }*/
    }
}