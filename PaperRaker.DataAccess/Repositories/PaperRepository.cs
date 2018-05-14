using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using NPoco;
using PaperRaker.Core.Model.System;
using PaperRaker.DataAccess.Queries;

namespace PaperRaker.DataAccess.Repositories
{
    public class PaperRepository : CoreRepository, IReadable<Paper>, IWritable<Paper>
    {
        private SQLiteConnection Connection = new SQLiteConnection("Data Source=Data.sqlite");
        
        public Paper Get(int id)
        {
            using (IDatabase db = CoreFactory.DbFactory.GetDatabase())
            {
                return db.SingleById<Paper>(id);
            }
        }

        public IEnumerable<Paper> GetGroup(long size = 20, long page = 1)
        {
            size = size > 100 ? 100 : size;
            using (IDatabase db = new Database(Connection))
            {
                Connection.Open();
                return db.Fetch<Paper>("SELECT * FROM Paper ORDER BY id");
            }
        }

        public void Add(Paper entity)
        {
            using (IDatabase db = new Database(Connection))
            {
                Connection.Open();
                db.Insert(entity);
            }
        }

        public void Delete(int id)
        {
            using (IDatabase db = new Database(Connection))
            {
                Connection.Open();
                db.Delete<Paper>(id);
            }
        }

        public void Update(Paper entity)
        {
            using (IDatabase db = new Database(Connection))
            {
                Connection.Open();
                db.Update(entity);
            }
        }
    }
}