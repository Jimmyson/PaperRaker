using System.Collections.Generic;
using NPoco;
using PaperRaker.Core.Model.System;
using PaperRaker.DataAccess.Queries;
using PaperRaker.DataAccess.SchemaConnection;

namespace PaperRaker.DataAccess.Repositories
{
    public class InstitutionRepository : IReadable<Institution>, IWritable<Institution>
    {
        private readonly IDatabase _schemaConn = SchemaConnectionFactory.CreateSchemaConnection("Core");
        
        public Institution Get(int id)
        {
            using (var db = _schemaConn)
            {
                return db.SingleById<Institution>(id);
            }
        }

        public IEnumerable<Institution> GetGroup(long size = 20, long page = 1)
        {
            //size = size > 100 ? 100 : size;
            using (var db = _schemaConn)
            {
                return db.Fetch<Institution>("SELECT * FROM Institution ORDER BY id");
            }
        }

        public void Add(Institution entity)
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
                db.Delete<Institution>(id);
            }
        }

        public void Update(Institution entity)
        {
            using (var db = _schemaConn)
            {
                db.Update(entity);
            }
        }
    }
}