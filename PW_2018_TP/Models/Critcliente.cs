using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("CriteriosCliente")]
    public class Critcliente
    {
        [Key]
        public int CritclienteId { get; set; }

        public int ParticularId { get; set; }

        public int ServicosId { get; set; }

        public int Simpatia { get; set; }

        [Display(Name = "Estado do Veículo")]
        public int EstadoCarro { get; set; }

        [Display(Name = "Data de Entrega")]
        public bool DataEntrega { get; set; }

        public Critcliente()
        {

        }
    }
}