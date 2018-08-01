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
    public class ClassifFornecedor
    {
        [Key]
        public int ClassificaFornecedorId { get; set; }

        public int ProfissionalId { get; set; }
        public Profissional Profissional { get; set; }

        public int CritFornecedorId { get; set; }

        public CritFornecedor CritFornecedor { get; set; }

        public ClassifFornecedor()
        {

        }
    }
}