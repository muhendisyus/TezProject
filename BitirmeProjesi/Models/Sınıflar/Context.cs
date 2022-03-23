using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace BitirmeProjesi.Models.Sınıflar
{
    public class Context : DbContext
    {
        public DbSet<TYTTurkKonulari> tYTTurkKonularis { get; set; }
        public DbSet<TYTMatKonulari> tYTMatKonularis { get; set; }
        public DbSet<TYTGeoKonulari> tYTGeoKonularis { get; set; }
        public DbSet<TYTFizKonulari> tYTFizKonularis { get; set; }
        public DbSet<TYTKimKonulari> tYTKimKonularis { get; set; }
        public DbSet<TYTBiyoKonulari> tYTBiyoKonularis { get; set; }
        public DbSet<TYTTarKonulari> tYTTarKonularis { get; set; }
        public DbSet<TYTCogKonulari> tYTCogKonularis { get; set; }
        public DbSet<TYTDinKonulari> tYTDinKonularis { get; set; }
        public DbSet<TYTFelKonulari> tYTFelKonularis { get; set; }
        public DbSet<AYTMatKonulari> aYTMatKonularis { get; set; }
        public DbSet<AYTGeoKonulari> aYTGeoKonularis { get; set; }
        public DbSet<AYTFizKonulari> aYTFizKonularis { get; set; }
        public DbSet<AYTKimKonulari> aYTKimKonularis { get; set; }
        public DbSet<AYTBiyoKonulari> aYTBiyoKonularis { get; set; }
        public DbSet<AYTEdebKonulari> aYTEdebKonularis { get; set; }
        public DbSet<AYTTarKonulari> aYTTarKonularis { get; set; }
        public DbSet<AYTCogKonulari> aYTCogKonularis { get; set; }
        public DbSet<AYTDinKonulari> aYTDinKonularis { get; set; }
        public DbSet<AYTFelKonulari> aYTFelKonularis { get; set; }
        public DbSet<TYTDeneme> tYTDenemes { get; set; }
        public DbSet<AYTDeneme> aYTDenemes { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Ogrenciler> ogrencilers { get; set; }
    }
}