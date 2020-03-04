using AutoMapper;
using BlogEsta.Data.Models;
using BlogEsta.Models;

namespace BlogEsta.Service.AutoMapper
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<Blog, BlogViewModel>();
            CreateMap<BlogViewModel, Blog>();
        }
    }
}
