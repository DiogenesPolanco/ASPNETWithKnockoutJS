using AutoMapper;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public BloggingContext _dbContext { get; set; }
        public HomeController()
        {
           
        }

        public ActionResult Index()
        {
            BlogViewModel ViewModel = new BlogViewModel();
            this._dbContext = new BloggingContext();
            if (this._dbContext.Blogs.Any() == false)
            {
                this._dbContext.Blogs.Add(new Blog
                {
                    Name = "Hola",
                    Posts = new List<Post>()
                {
                    new Post()
                    {
                        Content ="KLK",
                        Date = DateTime.Now,
                        Title ="Hola KLK",
                        User = "Diogenes Polanco"
                    }
                }
                });
                this._dbContext.SaveChanges();
            }
            var blog = _dbContext.Blogs.FirstOrDefault();
            ViewModel = Mapper.Map<BlogViewModel>(blog); 
            return View(ViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}