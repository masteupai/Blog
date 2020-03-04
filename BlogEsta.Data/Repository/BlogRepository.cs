using BlogEsta.Data.Interfaces;
using BlogEsta.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogEsta.Data.Repository
{
    public class BlogRepository : IRepository
    {
        private readonly BlogContext context;
        public BlogRepository(BlogContext context)
        {
            this.context = context;
        }

        public void Add(Blog entity)
        {
            
            this.context.Add(entity);
            this.context.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return this.context.Blogs.Find(id);
        }

        public IEnumerable<Blog> List()
        {
            return this.context.Blogs.ToList();
        }

        public void Remove(Blog entity)
        {
            this.context.Remove(entity);
            this.context.SaveChanges();
        }

        public void Update(Blog entity)
        {
            this.context.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
