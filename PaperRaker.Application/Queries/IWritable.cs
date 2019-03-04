﻿namespace PaperRaker.Aplication.Queries
{
    public interface IWritable<in T>
    {
        void Add(T entity);
        void Delete(uint id);
        void Update(T entity);
    }
}