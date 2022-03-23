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
    }
}