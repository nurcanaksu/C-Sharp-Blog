using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ilkproje.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            // var values = bm.GetList();
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll (int id)
        {
            ViewBag.i = id; //bloğa göre yorumları listelemek için
            var values = bm.GetBlogByID(id);
            return View(values);
        }

        public IActionResult BlogCode()
        {
            return View();
        }

    }
}
