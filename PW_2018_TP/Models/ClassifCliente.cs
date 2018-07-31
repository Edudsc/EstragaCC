using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    public class ClassifCliente
    {
        [Key]
        public int ClassifClienteId { get; set; }
     
        public int ParticularId { get; set; }

        public Particular Particular{get;set;}

        public ClassifCliente()
        {

        }
    }
}