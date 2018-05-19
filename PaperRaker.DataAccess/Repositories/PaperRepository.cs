using System.Collections.Generic;
using NPoco;
using PaperRaker.Core.Model.System;
using PaperRaker.DataAccess.Queries;
using PaperRaker.DataAccess.SchemaConnection;

namespace PaperRaker.DataAccess.Repositories
{
    public class PaperRepository : IReadable<Paper>, IWritable<Paper>
    {
        private readonly IDatabase _schemaConn = SchemaConnectionFactory.CreateSchemaConnection("CORE");
        
        public Paper Get(int id)
        {
            using (var db = _schemaConn)
            {
                return db.SingleById<Paper>(id);
            }
        }

        public IEnumerable<Paper> GetGroup(long size = 20, long page = 1)
        {
            //size = size > 100 ? 100 : size;
            using (var db = _schemaConn)
            {
                return db.Fetch<Paper>("SELECT * FROM Paper ORDER BY id");
            }
        }

        public void Add(Paper entity)
        {
            using (var db = _schemaConn)
            {
                db.Insert(entity);
            }
        }

        public void Delete(int id)
        {
            using (var db = _schemaConn)
            {
                db.Delete<Paper>(id);
            }
        }

        public void Update(Paper entity)
        {
            using (var db = _schemaConn)
            {
                db.Update(entity);
            }
        }
    }
}