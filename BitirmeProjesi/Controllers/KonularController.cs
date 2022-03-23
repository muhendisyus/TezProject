using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitirmeProjesi.Models.Sınıflar;
using PagedList;
using PagedList.Mvc;
namespace BitirmeProjesi.Controllers
{
    public class KonularController : Controller
    {
        Context c = new Context();
        // GET: Konular
        public ActionResult Index()
        {
            return View();
        }
        /////// TYT Konu Getir //////////////////////////
        public ActionResult TurkceKonuGetir(int? i)
        {
            var deger = c.tYTTurkKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult TYTMatKonuGetir(int? i)
        {
            var deger = c.tYTMatKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult TYTDersler()
        {
            return View();
        }
        public ActionResult AYTDersler()
        {
            return View();
        }
        public ActionResult TYTGeoKonuGetir(int? i)
        {
            var deger = c.tYTGeoKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult TYTFizKonuGetir()
        {
            var deger = c.tYTFizKonularis.ToList();
            return View(deger);
        }
        public ActionResult TYTKimKonuGetir(int? i)
        {
            var deger = c.tYTKimKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult TYTBiyoKonuGetir()
        {
            var deger = c.tYTBiyoKonularis.ToList();
            return View(deger);
        }
        public ActionResult TYTTarKonuGetir(int? i)
        {
            var deger = c.tYTTarKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult TYTCogKonuGetir(int? i)
        {
            var deger = c.tYTCogKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult TYTDinKonuGetir()
        {
            var deger = c.tYTDinKonularis.ToList();
            return View(deger);
        }
        public ActionResult TYTFelKonuGetir()
        {
            var deger = c.tYTFelKonularis.ToList();
            return View(deger);
        }

        /////// TYT Konu Getir //////////////////////////
        public ActionResult AYTMatKonuGetir(int? i)
        {
            var deger = c.aYTMatKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult AYTGeoKonuGetir()
        {
            var deger = c.aYTGeoKonularis.ToList();
            return View(deger);
        }
        public ActionResult AYTFizKonuGetir()
        {
            var deger = c.aYTFizKonularis.ToList();
            return View(deger);
        }
        public ActionResult AYTKimKonuGetir()
        {
            var deger = c.aYTKimKonularis.ToList();
            return View(deger);
        }
        public ActionResult AYTBiyoKonuGetir(int? i)
        {
            var deger = c.aYTBiyoKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult AYTEdebKonuGetir(int? i)
        {
            var deger = c.aYTEdebKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult AYTTarKonuGetir(int? i)
        {
            var deger = c.aYTTarKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        public ActionResult AYTCogKonuGetir()
        {
            var deger = c.aYTCogKonularis.ToList();
            return View(deger);
        }
        public ActionResult AYTDinKonuGetir()
        {
            var deger = c.aYTDinKonularis.ToList();
            return View(deger);
        }
        public ActionResult AYTFelKonuGetir(int? i)
        {
            var deger = c.aYTFelKonularis.ToList().ToPagedList(i ?? 1, 10);
            return View(deger);
        }
        ///////////////// TYT Konu Takibi ////////////////////////////
        public ActionResult TYTTurkKonuBitti(TYTTurkKonulari tt)
        {
            var deger = c.tYTTurkKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TurkceKonuGetir");
        }
        public ActionResult TYTTurkKonuBitmedi(TYTTurkKonulari tt)
        {
            var deger = c.tYTTurkKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TurkceKonuGetir");
        }
        public ActionResult TYTMatKonuBitti(TYTMatKonulari tt)
        {
            var deger = c.tYTMatKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTMatKonuGetir");
        }
        public ActionResult TYTMatKonuBitmedi(TYTMatKonulari tt)
        {
            var deger = c.tYTMatKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTMatKonuGetir");
        }
        public ActionResult TYTGeoKonuBitti(TYTGeoKonulari tt)
        {
            var deger = c.tYTGeoKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTGeoKonuGetir");
        }
        public ActionResult TYTGeoKonuBitmedi(TYTGeoKonulari tt)
        {
            var deger = c.tYTGeoKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTGeoKonuGetir");
        }
        public ActionResult TYTFizKonuBitti(TYTFizKonulari tt)
        {
            var deger = c.tYTFizKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTFizKonuGetir");
        }
        public ActionResult TYTFizKonuBitmedi(TYTFizKonulari tt)
        {
            var deger = c.tYTFizKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTFizKonuGetir");
        }
        public ActionResult TYTKimKonuBitti(TYTKimKonulari tt)
        {
            var deger = c.tYTKimKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTKimKonuGetir");
        }
        public ActionResult TYTKimKonuBitmedi(TYTKimKonulari tt)
        {
            var deger = c.tYTKimKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTKimKonuGetir");
        }
        public ActionResult TYTBiyoKonuBitti(TYTBiyoKonulari tt)
        {
            var deger = c.tYTBiyoKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTBiyoKonuGetir");
        }
        public ActionResult TYTBiyoKonuBitmedi(TYTBiyoKonulari tt)
        {
            var deger = c.tYTBiyoKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTBiyoKonuGetir");
        }
        public ActionResult TYTTarKonuBitti(TYTTarKonulari tt)
        {
            var deger = c.tYTTarKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTTarKonuGetir");
        }
        public ActionResult TYTTarKonuBitmedi(TYTTarKonulari tt)
        {
            var deger = c.tYTTarKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTTarKonuGetir");
        }
        public ActionResult TYTCogKonuBitti(TYTCogKonulari tt)
        {
            var deger = c.tYTCogKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTCogKonuGetir");
        }
        public ActionResult TYTCogKonuBitmedi(TYTCogKonulari tt)
        {
            var deger = c.tYTCogKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTCogKonuGetir");
        }
        public ActionResult TYTDinKonuBitti(TYTDinKonulari tt)
        {
            var deger = c.tYTDinKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTDinKonuGetir");
        }
        public ActionResult TYTDinKonuBitmedi(TYTDinKonulari tt)
        {
            var deger = c.tYTDinKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTDinKonuGetir");
        }
        public ActionResult TYTFelKonuBitti(TYTFelKonulari tt)
        {
            var deger = c.tYTFelKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTFelKonuGetir");
        }
        public ActionResult TYTFelKonuBitmedi(TYTFelKonulari tt)
        {
            var deger = c.tYTFelKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("TYTFelKonuGetir");
        }

        ///////////////// TYT Konu Takibi ////////////////////////////

        public ActionResult AYTMatKonuBitti(AYTMatKonulari tt)
        {
            var deger = c.aYTMatKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTMatKonuGetir");
        }
        public ActionResult AYTMatKonuBitmedi(AYTMatKonulari tt)
        {
            var deger = c.aYTMatKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTMatKonuGetir");
        }
        public ActionResult AYTGeoKonuBitti(AYTGeoKonulari tt)
        {
            var deger = c.aYTGeoKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTGeoKonuGetir");
        }
        public ActionResult AYTGeoKonuBitmedi(AYTGeoKonulari tt)
        {
            var deger = c.aYTGeoKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTGeoKonuGetir");
        }
        public ActionResult AYTFizKonuBitti(AYTFizKonulari tt)
        {
            var deger = c.aYTFizKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTFizKonuGetir");
        }
        public ActionResult AYTFizKonuBitmedi(AYTFizKonulari tt)
        {
            var deger = c.aYTFizKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTFizKonuGetir");
        }
        public ActionResult AYTKimKonuBitti(AYTKimKonulari tt)
        {
            var deger = c.aYTKimKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTKimKonuGetir");
        }
        public ActionResult AYTKimKonuBitmedi(AYTKimKonulari tt)
        {
            var deger = c.aYTKimKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTKimKonuGetir");
        }
        public ActionResult AYTBiyoKonuBitti(AYTBiyoKonulari tt)
        {
            var deger = c.aYTBiyoKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTBiyoKonuGetir");
        }
        public ActionResult AYTBiyoKonuBitmedi(AYTBiyoKonulari tt)
        {
            var deger = c.aYTBiyoKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTBiyoKonuGetir");
        }
        public ActionResult AYTEdebKonuBitti(AYTEdebKonulari tt)
        {
            var deger = c.aYTEdebKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTEdebKonuGetir");
        }
        public ActionResult AYTEdebKonuBitmedi(AYTEdebKonulari tt)
        {
            var deger = c.aYTEdebKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTEdebKonuGetir");
        }
        public ActionResult AYTTarKonuBitti(AYTTarKonulari tt)
        {
            var deger = c.aYTTarKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTTarKonuGetir");
        }
        public ActionResult AYTTarKonuBitmedi(AYTTarKonulari tt)
        {
            var deger = c.aYTTarKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTTarKonuGetir");
        }
        public ActionResult AYTCogKonuBitti(AYTCogKonulari tt)
        {
            var deger = c.aYTCogKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTCogKonuGetir");
        }
        public ActionResult AYTCogKonuBitmedi(AYTCogKonulari tt)
        {
            var deger = c.aYTCogKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTCogKonuGetir");
        }
        public ActionResult AYTDinKonuBitti(AYTDinKonulari tt)
        {
            var deger = c.aYTDinKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTDinKonuGetir");
        }
        public ActionResult AYTDinKonuBitmedi(AYTDinKonulari tt)
        {
            var deger = c.aYTDinKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTDinKonuGetir");
        }
        public ActionResult AYTFelKonuBitti(AYTFelKonulari tt)
        {
            var deger = c.aYTFelKonularis.Find(tt.ID);
            deger.Durum = true;      /*SQL de false olan konuları true yapar. Böylelikle o konu bitmiş olarak gözükür*/
            deger.Tarih = DateTime.Now; /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTFelKonuGetir");
        }
        public ActionResult AYTFelKonuBitmedi(AYTFelKonulari tt)
        {
            var deger = c.aYTFelKonularis.Find(tt.ID);
            deger.Durum = false;    /*SQL de true olan konuları false yapar. Böylelikle o konu bitmemiş olarak gözükür*/
            deger.Tarih = DateTime.Now;  /*Her değişiklik yaptığında o anki tarih ve saatini veri tabanına kaydeder*/
            c.SaveChanges();
            return RedirectToAction("AYTFelKonuGetir");
        }
    }
}