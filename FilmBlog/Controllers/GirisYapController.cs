using FilmBlog.Models.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FilmBlog.Controllers
{
    public class GirisYapController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault
                (x => x.Name == ad.Name && x.sifre == ad.sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Name, false);
                Session["Name"] = bilgiler.Name.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else //kullanıcı bilgisi doğru değil ise tekrar aynı sayfada kal
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Giris");
        }
    }
}