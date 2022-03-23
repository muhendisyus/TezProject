using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Sınıflar
{
    public class Ogrenciler
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KullaniciAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Sifre { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Mail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string GuvenlikSorusu { get; set; }
        public DateTime Tarih { get; set; }
    }
}