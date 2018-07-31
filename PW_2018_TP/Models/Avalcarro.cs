using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    public class Avalcarro
    {
        [Key]
        public int AvalcarroId { get; set; }

        //Foreign Key do Carro
        public int CarroId { get; set; }
        public Carro Carro { get; set; }
        
        public int ServicosId { get; set; }
        public Servicos Servicos { get; set; }

        [Display(Name="Consumo")]
        public int Consumo { get; set; }

        [Display(Name = "Espaço 1 a 5")]
        public int Espaco { get; set; }

        [Display(Name = "Avarias (Sim/Não)")]
        public bool Avarias { get; set; }

        [Display(Name = "Limpeza 1 a 5")]
        public int Limpeza { get; set; }

        public Avalcarro()
        {

        }
    }
}