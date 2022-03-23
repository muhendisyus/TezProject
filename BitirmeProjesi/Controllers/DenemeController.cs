using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitirmeProjesi.Models.Sınıflar;
namespace BitirmeProjesi.Controllers
{
    public class DenemeController : Controller
    {
        Context c = new Context();
        // GET: Deneme
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TYTDenemeListele()
        {
            var deger = c.tYTDenemes.OrderByDescending(x => x.ID).ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult TYTDenemeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TYTDenemeEkle(TYTDeneme td)
        {
            c.tYTDenemes.Add(td);
            c.SaveChanges();
            return RedirectToAction("TYTDenemeListele");
        }
        public ActionResult TYTDenemeSil(int id)
        {
            var td = c.tYTDenemes.Find(id);
            c.tYTDenemes.Remove(td);
            c.SaveChanges();
            return RedirectToAction("TYTDenemeListele");
        }
        public ActionResult TYTDenemeTasi(int id)
        {
            var td = c.tYTDenemes.Find(id);
            return View("TYTDenemeTasi", td);
        }
        public ActionResult TYTDenemeGuncelle(TYTDeneme td)
        {
            var deger = c.tYTDenemes.Find(td.ID);
            deger.TurkNet = td.TurkNet;
            deger.SosNet = td.SosNet;
            deger.MatNet = td.MatNet;
            deger.FenNet = td.FenNet;
            deger.TopNet = td.TopNet;
            deger.Puan = td.Puan;
            deger.Yayın = td.Yayın;
            deger.Tarih = td.Tarih;
            c.SaveChanges();
            return RedirectToAction("TYTDenemeListele");
        }
        public ActionResult AYTDenemeListele()
        {
            var deger = c.aYTDenemes.OrderByDescending(x => x.ID).ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult AYTDenemeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AYTDenemeEkle(AYTDeneme ad)
        {
            c.aYTDenemes.Add(ad);
            c.SaveChanges();
            return RedirectToAction("AYTDenemeListele");
        }
        public ActionResult AYTDenemeSil(int id)
        {
            var ad = c.aYTDenemes.Find(id);
            c.aYTDenemes.Remove(ad);
            c.SaveChanges();
            return RedirectToAction("AYTDenemeListele");
        }
        public ActionResult AYTDenemeTasi(int id)
        {
            var ad = c.aYTDenemes.Find(id);
            return View("AYTDenemeTasi", ad);
        }
        public ActionResult AYTDenemeGuncelle(AYTDeneme ad)
        {
            var deger = c.aYTDenemes.Find(ad.ID);
            deger.EdebNet = ad.EdebNet;
            deger.SosNet = ad.SosNet;
            deger.MatNet = ad.MatNet;
            deger.FenNet = ad.FenNet;
            deger.TopNet = ad.TopNet;
            deger.Puan = ad.Puan;
            deger.Yayın = ad.Yayın;
            deger.Tarih = ad.Tarih;
            c.SaveChanges();
            return RedirectToAction("AYTDenemeListele");
        }
    }
}