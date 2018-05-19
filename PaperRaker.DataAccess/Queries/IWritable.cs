namespace PaperRaker.DataAccess.Queries
{
    public interface IWritable<in T>
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
    }
}