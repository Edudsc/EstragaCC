using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    public class ClassifFornecedor
    {
        [Key]
        public int ClassificaFornecedorId { get; set; }

        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        public ClassifFornecedor()
        {

        }
    }
}