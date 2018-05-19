using System.Collections.Generic;
using NPoco;
using PaperRaker.Core.Model.System;
using PaperRaker.DataAccess.Queries;
using PaperRaker.DataAccess.SchemaConnection;

namespace PaperRaker.DataAccess.Repositories
{
    public class AuthorRepository : IReadable<Author>, IWritable<Author>
    {
        private readonly IDatabase _schemaConn = SchemaConnectionFactory.CreateSchemaConnection("CORE");
        
        public Author Get(int id)
        {
            using (var db = _schemaConn)
            {
                return db.SingleById<Author>(id);
            }
        }

        public IEnumerable<Author> GetGroup(long size = 20, long page = 1)
        {
            //size = size > 100 ? 100 : size;
            using (var db = _schemaConn)
            {
                return db.Fetch<Author>("SELECT * FROM Author ORDER BY id");
            }
        }

        public void Add(Author entity)
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
                db.Delete<Author>(id);
            }
        }

        public void Update(Author entity)
        {
            using (var db = _schemaConn)
            {
                db.Update(entity);
            }
        }
    }
}