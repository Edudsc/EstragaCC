using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("CondicoesdeAluguer")]
    public class CondAlugar
    {
        [Key]
        public int CondAlugaId { get; set; }

        [Required]
        [Display(Name = "ID do Carro")]
        public int CarroId { get; set; }

        //FK da zona

        [Required]
        [Display(Name = "Zona de Recolha")]
        public int ZonaId { get; set; }
        public Zonas Zona { get; set; }


        [Required]
        [Display(Name = "DataMax de aluguer(dias)")]
        public int DataDevolucao { get; set; }


        [Required]
        [Display(Name = "Seguro")]
        public string Seguro { get; set; }


        [Required]
        [Display(Name = "Pré-Pagamento (Sim/Não)")]
        public bool Pagaradiantado { get; set; }


        [Required]
        [Display(Name = "Idade minima para alugar")]
        public int Idade { get; set; }


        [Required]
        [Display(Name = "Tempo de Carta (Meses)")]
        public int Tempocarta { get; set; }


        [Required]
        [Display(Name = "Classificação minima requerida")]
        public int CassificacaoMinCli { get; set; }

        public CondAlugar()
        {

        }
    }
}