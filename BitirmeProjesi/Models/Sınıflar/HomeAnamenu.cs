using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Sınıflar
{
    public class HomeAnamenu
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Baslik { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string Aciklama { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Gorsel { get; set; }
    }
}