using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("DatasAlugar")]
    public class DatasAlugar
    {
        [Key]
        public int DatasAlugarId { get; set; }

        public int CarroId { get; set; }

        public DateTime DataInit { get; set; }

        public DateTime DataFim { get; set; }

        public DatasAlugar()
        {

        }
    }
}