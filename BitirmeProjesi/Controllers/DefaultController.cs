using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitirmeProjesi.Models.Sınıflar;
namespace BitirmeProjesi.Controllers
{
    public class DefaultController : Controller
    {
    Context c = ne Context();
        // GET: Default
        public ActionResult Index()
        {
            var dgr = c.tYTMatKonulari.ToList();
            return View();
        }
    }
}
