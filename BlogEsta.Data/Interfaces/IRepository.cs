using BlogEsta.Data.Models;
using System.Collections.Generic;
namespace BlogEsta.Data.Interfaces
{
    public interface IRepository
    {
        void Add(Blog entity);
        void Update(Blog entity);
        void Remove(Blog entity);
        IEnumerable<Blog> List();
        Blog GetById(int id);
    }
}
