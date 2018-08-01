using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("ClassificaCliente")]
    public class ClassifCliente
    {
        [Key]
        public int ClassifClienteId { get; set; }
     
        public int ParticularId { get; set; }

        public Particular Particular{get;set;}

        public int CritClienteId { get; set; }

        public Critcliente Critcliente { get; set; }

        public ClassifCliente()
        {

        }
    }
}