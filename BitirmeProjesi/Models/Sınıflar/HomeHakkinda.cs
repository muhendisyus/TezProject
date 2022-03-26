using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Sınıflar
{
    public class HomeHakkinda
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Baslik { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string Aciklama { get; set; }
        //alan 1
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Baslik1 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Aciklama1 { get; set; }
        //alan 2
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Baslik2 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Aciklama2 { get; set; }
        //alan 3
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Baslik3 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Aciklama3 { get; set; }
        //alan 4
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Baslik4 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Aciklama4 { get; set; }
    }
}