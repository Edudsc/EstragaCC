using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("Fotos")]
    public class FotosdoCarro
    {
        [Key]
        public int FotosdoCarroId { get; set; }

        public int CarroId { get; set; }

        public FotosdoCarro()
        {

        }
    }
}