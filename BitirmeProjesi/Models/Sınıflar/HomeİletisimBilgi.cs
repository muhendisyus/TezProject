using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Sınıflar
{
    public class HomeİletisimBilgi
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Adres { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Mail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Tel { get; set; }
    }
}