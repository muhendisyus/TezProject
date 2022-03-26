using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitirmeProjesi.Models.Sınıflar;
namespace BitirmeProjesi.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HomeAnamenuListele()
        {
            var dgr = c.homeAnamenus.ToList();
            return PartialView(dgr);
        }
        public PartialViewResult HomeHakkindaListele()
        {
            var dgr = c.homeHakkindas.ToList();
            return PartialView(dgr);
        }
        public PartialViewResult HomeNeIseYararListele()
        {
            var dgr = c.homeNeİseYarars.ToList();
            return PartialView(dgr);
        }
        public PartialViewResult HomeSSSListele()
        {
            var dgr = c.homeSSSes.ToList();
            return PartialView(dgr);
        }
        public PartialViewResult HomeİletisimBilgiListele()
        {
            var dgr = c.homeİletisimBilgis.ToList();
            return PartialView(dgr);
        }
    
    }
}