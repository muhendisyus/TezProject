using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Sınıflar
{
    public class HomeSSS
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string AltBaslik { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string Aciklama { get; set; }
        
    }
}