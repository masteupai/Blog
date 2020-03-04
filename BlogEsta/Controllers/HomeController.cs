using BlogEsta.Data;
using BlogEsta.Data.Models;
using BlogEsta.Data.Repository;
using BlogEsta.Models;
using BlogEsta.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;


namespace BlogEsta.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;
        
        public HomeController(IService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var postagens = _service.List();
            return View(postagens);
        }
        [HttpGet]
        public IActionResult Postar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Postar(BlogViewModel blog)
        {
            try
            {
                _service.Add(blog);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View();
            }
        }
        [HttpGet]
        public IActionResult Remover(int id)
        {
            var blog = (BlogViewModel)_service.GetById(id);
            return View(blog);
        }
        [HttpPost]
        public IActionResult Remover(BlogViewModel blogVM)
        {
            try
            {
                var blog = _service.GetById(blogVM.Id);
                if (blog != null)
                    _service.Remove(blog);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View();
            }
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var blog = _service.GetById(id);
            return View(blog);
        }
        [HttpPost]
        public IActionResult Editar(BlogViewModel blogVM)
        {
            try
            {                
                _service.Update(blogVM);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View();
            }
        }
    }
}