using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FilmBlog.Models.Class; 
//classı dahil edip bundan nesne türeteceğim

namespace FilmBlog.Controllers
{
    public class GirisController : Controller
    {
        // GET: Giris
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Anasayfas.ToList();   
            return View(deger);
        }
       
    }
}