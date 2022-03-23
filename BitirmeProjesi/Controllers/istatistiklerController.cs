using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitirmeProjesi.Models.Sınıflar;
namespace BitirmeProjesi.Controllers
{
    public class istatistiklerController : Controller
    {
        Context c = new Context();
        // GET: istatistikler
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Konularistatistigi()
        {
            return View ();
        }
        public ActionResult Denemeleristatistigi()
        {
            return View();
        }
        public PartialViewResult TYTDenemeTablo1()
        {
            var dgr = c.tYTDenemes.OrderByDescending(x=>x.TopNet).Take(5).ToList();
            return PartialView(dgr);
        }
        public PartialViewResult TYTDenemeTablo2()
        {
            var dgr = c.tYTDenemes.OrderByDescending(x => x.Puan).Take(5).ToList();
            return PartialView(dgr);
        }
        public PartialViewResult AYTDenemeTablo1()
        {
            var dgr = c.aYTDenemes.OrderByDescending(x => x.TopNet).Take(5).ToList();
            return PartialView(dgr);
        }
        public PartialViewResult AYTDenemeTablo2()
        {
            var dgr = c.aYTDenemes.OrderByDescending(x => x.Puan).Take(5).ToList();
            return PartialView(dgr);
        }
        public ActionResult TYTistatistigi()
        {
            //Türkçe
            var ttop = c.tYTTurkKonularis.Count();
            var tbiten = c.tYTTurkKonularis.Count(x => x.Durum == true);
            var tkalan = c.tYTTurkKonularis.Count(x => x.Durum == false);
            var tturk = ( tbiten* 100) / (ttop);
            ViewBag.tbit = tbiten;
            ViewBag.tkal = tkalan;
            ViewBag.ttr = tturk;
            //Matematik
            var mtop = c.tYTMatKonularis.Count();
            var mbiten = c.tYTMatKonularis.Count(x => x.Durum == true);
            var mkalan = c.tYTMatKonularis.Count(x => x.Durum == false);
            var mturk = (mbiten * 100) / (mtop);
            ViewBag.mbit = mbiten;
            ViewBag.mkal = mkalan;
            ViewBag.mtr = mturk;
            //Geometri
            var gtop = c.tYTGeoKonularis.Count();
            var gbiten = c.tYTGeoKonularis.Count(x => x.Durum == true);
            var gkalan = c.tYTGeoKonularis.Count(x => x.Durum == false);
            var gturk = (gbiten * 100) / (gtop);
            ViewBag.gbit = gbiten;
            ViewBag.gkal = gkalan;
            ViewBag.gtr = gturk;
            //Fizik
            var ftop= c.tYTFizKonularis.Count();
            var fbiten = c.tYTFizKonularis.Count(x => x.Durum == true);
            var fkalan = c.tYTFizKonularis.Count(x => x.Durum == false);
            var fturk = (fbiten * 100) / (ftop);
            ViewBag.fbit = fbiten;
            ViewBag.fkal = fkalan;
            ViewBag.ftr = fturk;
            //Kimya
            var ktop = c.tYTKimKonularis.Count();
            var kbiten = c.tYTKimKonularis.Count(x => x.Durum == true);
            var kkalan = c.tYTKimKonularis.Count(x => x.Durum == false);
            var kturk = (kbiten * 100) / (ktop);
            ViewBag.kbit = kbiten;
            ViewBag.kkal = kkalan;
            ViewBag.ktr = kturk;
            //Biyoloji
            var btop = c.tYTBiyoKonularis.Count();
            var bbiten = c.tYTBiyoKonularis.Count(x => x.Durum == true);
            var bkalan = c.tYTBiyoKonularis.Count(x => x.Durum == false);
            var bturk = (bbiten * 100) / (btop);
            ViewBag.bbit = bbiten;
            ViewBag.bkal = bkalan;
            ViewBag.btr = bturk;
            //Tarih
            var tttop = c.tYTTarKonularis.Count();
            var ttbiten = c.tYTTarKonularis.Count(x => x.Durum == true);
            var ttkalan = c.tYTTarKonularis.Count(x => x.Durum == false);
            var ttturk = (ttbiten * 100) / (tttop);
            ViewBag.ttbit = ttbiten;
            ViewBag.ttkal = ttkalan;
            ViewBag.tttr = ttturk;
            //Coğrafya
            var ctop = c.tYTCogKonularis.Count();
            var cbiten = c.tYTCogKonularis.Count(x => x.Durum == true);
            var ckalan = c.tYTCogKonularis.Count(x => x.Durum == false);
            var cturk = (cbiten * 100) / (ctop);
            ViewBag.cbit = cbiten;
            ViewBag.ckal = ckalan;
            ViewBag.ctr = cturk;
            //Din
            var dtop = c.tYTDinKonularis.Count();
            var dbiten = c.tYTDinKonularis.Count(x => x.Durum == true);
            var dkalan = c.tYTDinKonularis.Count(x => x.Durum == false);
            var dturk = (dbiten * 100) / (dtop);
            ViewBag.dbit = dbiten;
            ViewBag.dkal = dkalan;
            ViewBag.dtr = dturk;
            //Fel
            var fftop = c.tYTFelKonularis.Count();
            var ffbiten = c.tYTFelKonularis.Count(x => x.Durum == true);
            var ffkalan = c.tYTFelKonularis.Count(x => x.Durum == false);
            var ffturk = (ffbiten * 100) / (fftop);
            ViewBag.ffbit = ffbiten;
            ViewBag.ffkal = ffkalan;
            ViewBag.fftr = ffturk;
            //Sayısal
            var saytop = (mtop + gtop + ftop + ktop + btop);
            var saybit = (mbiten + gbiten + fbiten + kbiten + bbiten);
            var saykal = (mkalan + gkalan + fkalan + kkalan + bkalan);
            var say = (saybit * 100) / (saytop);
            ViewBag.saybit = saybit;
            ViewBag.saykal = saykal;
            ViewBag.say = say;
            //Eşit Ağırlık
            var eatop = (mtop + gtop + ttop);
            var eabit = (mbiten + gbiten + tbiten);
            var eakal = (mkalan + gkalan + tkalan);
            var ea = (eabit * 100) / (eatop);
            ViewBag.eabit = eabit;
            ViewBag.eakal = eakal;
            ViewBag.ea = ea;
            //Sözel
            var soztop = (ttop + tttop + ctop + dtop + fftop);
            var sozbit = (tbiten + ttbiten + cbiten + dbiten + ffbiten);
            var sozkal = (tkalan + ttkalan + ckalan + dkalan + ffkalan);
            var soz = (sozbit * 100) / (soztop);
            ViewBag.sozbit = sozbit;
            ViewBag.sozkal = sozkal;
            ViewBag.soz = soz;
            return View();
        }
        //AYT Dersleri İstatistiği 

        public ActionResult AYTistatistigi()
        {
            
            //Matematik
            var mtop = c.aYTMatKonularis.Count();
            var mbiten = c.aYTMatKonularis.Count(x => x.Durum == true);
            var mkalan = c.aYTMatKonularis.Count(x => x.Durum == false);
            var mturk = (mbiten * 100) / (mtop);
            ViewBag.mbit = mbiten;
            ViewBag.mkal = mkalan;
            ViewBag.mtr = mturk;
            //Geometri
            var gtop = c.aYTGeoKonularis.Count();
            var gbiten = c.aYTGeoKonularis.Count(x => x.Durum == true);
            var gkalan = c.aYTGeoKonularis.Count(x => x.Durum == false);
            var gturk = (gbiten * 100) / (gtop);
            ViewBag.gbit = gbiten;
            ViewBag.gkal = gkalan;
            ViewBag.gtr = gturk;
            //Fizik
            var ftop = c.aYTFelKonularis.Count();
            var fbiten = c.aYTFizKonularis.Count(x => x.Durum == true);
            var fkalan = c.aYTFizKonularis.Count(x => x.Durum == false);
            var fturk = (fbiten * 100) / (ftop);
            ViewBag.fbit = fbiten;
            ViewBag.fkal = fkalan;
            ViewBag.ftr = fturk;
            //Kimya
            var ktop = c.aYTKimKonularis.Count();
            var kbiten = c.aYTKimKonularis.Count(x => x.Durum == true);
            var kkalan = c.aYTKimKonularis.Count(x => x.Durum == false);
            var kturk = (kbiten * 100) / (ktop);
            ViewBag.kbit = kbiten;
            ViewBag.kkal = kkalan;
            ViewBag.ktr = kturk;
            //Biyoloji
            var btop = c.aYTBiyoKonularis.Count();
            var bbiten = c.aYTBiyoKonularis.Count(x => x.Durum == true);
            var bkalan = c.aYTBiyoKonularis.Count(x => x.Durum == false);
            var bturk = (bbiten * 100) / (btop);
            ViewBag.bbit = bbiten;
            ViewBag.bkal = bkalan;
            ViewBag.btr = bturk;
            //Türkçe
            var ttop = c.aYTEdebKonularis.Count();
            var tbiten = c.aYTEdebKonularis.Count(x => x.Durum == true);
            var tkalan = c.aYTEdebKonularis.Count(x => x.Durum == false);
            var tturk = (tbiten * 100) / (ttop);
            ViewBag.tbit = tbiten;
            ViewBag.tkal = tkalan;
            ViewBag.ttr = tturk;
            //Tarih
            var tttop = c.aYTTarKonularis.Count();
            var ttbiten = c.aYTTarKonularis.Count(x => x.Durum == true);
            var ttkalan = c.aYTTarKonularis.Count(x => x.Durum == false);
            var ttturk = (ttbiten * 100) / (tttop);
            ViewBag.ttbit = ttbiten;
            ViewBag.ttkal = ttkalan;
            ViewBag.tttr = ttturk;
            //Coğrafya
            var ctop = c.aYTCogKonularis.Count();
            var cbiten = c.aYTCogKonularis.Count(x => x.Durum == true);
            var ckalan = c.aYTCogKonularis.Count(x => x.Durum == false);
            var cturk = (cbiten * 100) / (ctop);
            ViewBag.cbit = cbiten;
            ViewBag.ckal = ckalan;
            ViewBag.ctr = cturk;
            //Din
            var dtop = c.aYTDinKonularis.Count();
            var dbiten = c.aYTDinKonularis.Count(x => x.Durum == true);
            var dkalan = c.aYTDinKonularis.Count(x => x.Durum == false);
            var dturk = (dbiten * 100) / (dtop);
            ViewBag.dbit = dbiten;
            ViewBag.dkal = dkalan;
            ViewBag.dtr = dturk;
            //Fel
            var fftop = c.aYTFelKonularis.Count();
            var ffbiten = c.aYTFelKonularis.Count(x => x.Durum == true);
            var ffkalan = c.aYTFelKonularis.Count(x => x.Durum == false);
            var ffturk = (ffbiten * 100) / (fftop);
            ViewBag.ffbit = ffbiten;
            ViewBag.ffkal = ffkalan;
            ViewBag.fftr = ffturk;
            //Sayısal
            var saytop = (mtop + gtop + ftop + ktop + btop);
            var saybit = (mbiten + gbiten + fbiten + kbiten + bbiten);
            var saykal = (mkalan + gkalan + fkalan + kkalan + bkalan);
            var say = (saybit * 100) / (saytop);
            ViewBag.saybit = saybit;
            ViewBag.saykal = saykal;
            ViewBag.say = say;
            //Eşit Ağırlık
            var eatop = (mtop + gtop + ttop);
            var eabit = (mbiten + gbiten + tbiten);
            var eakal = (mkalan + gkalan + tkalan);
            var ea = (eabit * 100) / (eatop);
            ViewBag.eabit = eabit;
            ViewBag.eakal = eakal;
            ViewBag.ea = ea;
            //Sözel
            var soztop = (ttop + tttop + ctop + dtop + fftop);
            var sozbit = (tbiten + ttbiten + cbiten + dbiten + ffbiten);
            var sozkal = (tkalan + ttkalan + ckalan + dkalan + ffkalan);
            var soz = (sozbit * 100) / (soztop);
            ViewBag.sozbit = sozbit;
            ViewBag.sozkal = sozkal;
            ViewBag.soz = soz;
            return View();
        }
        public ActionResult TYTDenemeistatistigi()
        {
            var ds = c.tYTDenemes.Count();
            var en = (from x in c.tYTDenemes orderby x.TopNet descending select x.TopNet).FirstOrDefault();
            var ep = (from x in c.tYTDenemes orderby x.Puan descending select x.Puan).FirstOrDefault();
            var ys = (from x in c.tYTDenemes select x.Yayın).Distinct().Count();
            var dst = (from x in c.tYTDenemes orderby x.ID descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            var ent = (from x in c.tYTDenemes orderby x.TopNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            var ept = (from x in c.tYTDenemes orderby x.Puan descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            var yst = (from x in c.tYTDenemes orderby x.ID descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.ds = ds;
            ViewBag.en = en;
            ViewBag.ep = ep;
            ViewBag.ys = ys;
            ViewBag.dst = dst;
            ViewBag.ent = ent;
            ViewBag.ept = ent;
            ViewBag.yst = yst;

            //Derslere göre en yüksek net ve tarihi
            var ten = (from x in c.tYTDenemes orderby x.TurkNet descending select x.TurkNet).FirstOrDefault();
            var tent = (from x in c.tYTDenemes orderby x.TurkNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.ten = ten;
            ViewBag.tent = tent;

            var sen = (from x in c.tYTDenemes orderby x.SosNet descending select x.SosNet).FirstOrDefault();
            var sent = (from x in c.tYTDenemes orderby x.SosNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.sen = sen;
            ViewBag.sent = sent;

            var men = (from x in c.tYTDenemes orderby x.MatNet descending select x.MatNet).FirstOrDefault();
            var ment = (from x in c.tYTDenemes orderby x.MatNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.men = men;
            ViewBag.ment = ment;

            var fen = (from x in c.tYTDenemes orderby x.FenNet descending select x.FenNet).FirstOrDefault();
            var fent = (from x in c.tYTDenemes orderby x.FenNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.fen = fen;
            ViewBag.fent = fent;

            return View();
        }
        public ActionResult AYTDenemeistatistigi()
        {
            var ds = c.aYTDenemes.Count();
            var en = (from x in c.aYTDenemes orderby x.TopNet descending select x.TopNet).FirstOrDefault();
            var ep = (from x in c.aYTDenemes orderby x.Puan descending select x.Puan).FirstOrDefault();
            var ys = (from x in c.aYTDenemes select x.Yayın).Distinct().Count();
            var dst = (from x in c.aYTDenemes orderby x.ID descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            var ent = (from x in c.aYTDenemes orderby x.TopNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            var ept = (from x in c.aYTDenemes orderby x.Puan descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            var yst = (from x in c.aYTDenemes orderby x.ID descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.ds = ds;
            ViewBag.en = en;
            ViewBag.ep = ep;
            ViewBag.ys = ys;
            ViewBag.dst = dst;
            ViewBag.ent = ent;
            ViewBag.ept = ent;
            ViewBag.yst = yst;

            //Derslere göre en yüksek net ve tarihi
            var ten = (from x in c.aYTDenemes orderby x.EdebNet descending select x.EdebNet).FirstOrDefault();
            var tent = (from x in c.aYTDenemes orderby x.EdebNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.ten = ten;
            ViewBag.tent = tent;

            var sen = (from x in c.aYTDenemes orderby x.SosNet descending select x.SosNet).FirstOrDefault();
            var sent = (from x in c.aYTDenemes orderby x.SosNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.sen = sen;
            ViewBag.sent = sent;

            var men = (from x in c.aYTDenemes orderby x.MatNet descending select x.MatNet).FirstOrDefault();
            var ment = (from x in c.aYTDenemes orderby x.MatNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.men = men;
            ViewBag.ment = ment;

            var fen = (from x in c.aYTDenemes orderby x.FenNet descending select x.FenNet).FirstOrDefault();
            var fent = (from x in c.aYTDenemes orderby x.FenNet descending select x.Tarih).FirstOrDefault().ToString("dd.MM.yyyy");
            ViewBag.fen = fen;
            ViewBag.fent = fent;

            return View();
        }
    }
}