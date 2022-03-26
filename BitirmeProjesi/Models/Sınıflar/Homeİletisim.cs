using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Sınıflar
{
    public class Homeİletisim
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KullaniciAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Mail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Baslik { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string Mesaj { get; set; }
    }
}