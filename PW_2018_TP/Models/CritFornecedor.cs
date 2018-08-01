using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("CriteriosFornecedor")]
    public class CritFornecedor
    {
        [Key]
        public int CritFornecedorId { get; set; }

        public int UserId { get; set; }

        public int ServicosId { get; set; }

        public int Simpatia { get; set; }

        [Display(Name = "Estado do Veículo")]
        public int EstadoCarro { get; set; }

        [Display(Name = "Data de Entrega")]
        public bool DataEntrega { get; set; }

        [Display(Name = "Responsividade")]
        public int RapidezRsp { get; set; }

        public CritFornecedor()
        {

        }

    }
}