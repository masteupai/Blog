using BlogEsta.Data.Models;
using System;

namespace BlogEsta.Models
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Autor { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DateCriacao { get; set; }

        public static explicit operator Blog(BlogViewModel blogViewModel)
        {
            return new Blog()
            {
                Id = blogViewModel.Id,
                Ativo = blogViewModel.Ativo,
                Autor = blogViewModel.Autor,
                DateCriacao = blogViewModel.DateCriacao,
                Texto = blogViewModel.Texto,
                Titulo = blogViewModel.Titulo,
                Url = blogViewModel.Url
            };
        }
    }
}
