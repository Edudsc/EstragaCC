using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("Zonas")]
    public class Zonas
    {
        [Key]
        public int ZonasId { get; set; }

        [Display(Name="Zona de Aluger")]
        public string NomeZona { get; set; }

        public Zonas()
        {

        }
        
    }
}