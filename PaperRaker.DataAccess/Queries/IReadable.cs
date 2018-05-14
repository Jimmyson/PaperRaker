using System;
using System.Collections.Generic;
using NPoco;

namespace PaperRaker.DataAccess.Queries
{
    public interface IReadable<T>
    {
        T Get(int id);
        IEnumerable<T> GetGroup(long size = 20, long page = 1);
    }
}