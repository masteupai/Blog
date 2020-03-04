using System;


namespace BlogEsta.Data.Models
{
    public class Blog
    {       
        public int Id { get; set; }
        public string Url { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Autor { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DateCriacao { get; set; }

    }
}
