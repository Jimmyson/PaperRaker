using System.Collections.Generic;

namespace PaperRaker.Application.Queries
{
    public interface IReadable<out T>
    {
        T Get(uint id);
        IEnumerable<T> GetGroup(uint size = 20, uint page = 1);
    }
}