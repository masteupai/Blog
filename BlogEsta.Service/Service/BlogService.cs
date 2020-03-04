using BlogEsta.Data.Interfaces;
using BlogEsta.Data.Models;
using BlogEsta.Models;
using BlogEsta.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace BlogEsta.Service.Service
{
    public class BlogService : IService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public BlogService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Add(BlogViewModel entity)
        {
            if (VerificarTituloEUrlExiste(entity))
                throw new ArgumentException("Titulo já existe");
            entity.DateCriacao = DateTime.Now;
            _repository.Add(_mapper.Map<Blog>(entity));
        }

        public BlogViewModel GetById(int id)
        {
            return _mapper.Map<BlogViewModel>(_repository.GetById(id));
        }

        public IEnumerable<BlogViewModel> List()
        {
            var lista = _repository.List().OrderByDescending(x => x.DateCriacao);
            //yield return _mapper.Map<BlogViewModel>(lista);
            foreach (var item in lista)
            {
                yield return _mapper.Map<BlogViewModel>(item);
            }

        }

        public void Remove(BlogViewModel entity)
        {
            entity.Ativo = false;
            _repository.Update(_mapper.Map<Blog>(entity));
        }

        public void Update(BlogViewModel entity)
        {
            if (VerificarTituloEUrlExiste(entity))
                throw new ArgumentException("Titulo já existe");
            _repository.Update(_mapper.Map<Blog>(entity));
        }

        public bool VerificarTituloEUrlExiste(BlogViewModel entity)
        {
            return _repository.List().Any(x => x.Titulo.Equals(entity.Titulo) && x.Url.Equals(entity.Url));
            //return _repository.List().Any(x => x.Titulo == titulo);
        }
    }
}
