using BlogEsta.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BlogEsta.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BlogContext context;
        public Repository(BlogContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            this.context.Add(entity);           
        } 
        public void Remove(T entity)
        {
            this.context.Remove(entity);
        }

        public void Update(T entity)
        {
            this.context.Update(entity);
        }
    }
}
