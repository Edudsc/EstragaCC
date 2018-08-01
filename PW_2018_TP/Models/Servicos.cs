using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("Servicos")]
    public class Servicos
    {
        [Key]
        public int ServicosId { get; set; }

        public int CarroId { get; set; }

        public int ParticularId { get; set; }

        public int FornecedorId { get; set; }

        public int DatasAlugarId { get; set; }

        public DatasAlugar DatasAlugar { get; set; }

        public Servicos()
        {

        }
    }
}