using BlogEsta.Data.Models;
using BlogEsta.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEsta.Service.Interfaces
{
    public interface IService
    {
        void Add(BlogViewModel entity);
        void Update(BlogViewModel entity);
        void Remove(BlogViewModel entity);
        IEnumerable<BlogViewModel> List();
        BlogViewModel GetById(int id);
    }
}
