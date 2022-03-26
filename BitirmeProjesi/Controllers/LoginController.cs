using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitirmeProjesi.Models.Sınıflar;
namespace BitirmeProjesi.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayitOl(Ogrenciler s)
        {
            var dgr = c.ogrencilers.Add(s);
            return RedirectToAction("TYTDersler", "Konular");
        }
        public ActionResult GirisYap()
        {
            return View();
        }
    }
}