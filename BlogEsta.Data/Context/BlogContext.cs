using BlogEsta.Data.Mapping;
using BlogEsta.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEsta.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogMapping).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
