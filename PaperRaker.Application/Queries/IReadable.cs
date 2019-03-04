using System.Collections.Generic;

namespace PaperRaker.Application.Queries
{
    public interface IReadable<out T>
    {
        T Get(int id);
        IEnumerable<T> GetGroup(long size = 20, long page = 1);
    }
}