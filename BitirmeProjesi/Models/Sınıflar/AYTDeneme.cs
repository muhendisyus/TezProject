using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Sınıflar
{
    public class AYTDeneme
    {
        [Key]
        public int ID { get; set; }
        public decimal EdebNet { get; set; }
        public decimal SosNet { get; set; }
        public decimal MatNet { get; set; }
        public decimal FenNet { get; set; }
        public decimal TopNet { get; set; }
        public decimal Puan { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Yayın { get; set; }
        public DateTime Tarih { get; set; }
    }
}