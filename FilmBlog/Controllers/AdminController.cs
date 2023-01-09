using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmBlog.Models.Class;

namespace FilmBlog.Controllers
{
    public class AdminController : Controller
    {
        

        Context c = new Context();

        
        public ActionResult Index()
        {
            var deger = c.Anasayfas.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniFilm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniFilm(Anasayfa a)
        {
            c.Anasayfas.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles ="A")]
        public ActionResult FilmSil(int id)
        {
            var f = c.Anasayfas.Find(id);
            c.Anasayfas.Remove(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}