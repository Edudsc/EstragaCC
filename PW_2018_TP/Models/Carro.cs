using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    public enum Combustivel
    {
        Gasolina,
        Gasóleo,
        Gas,
        Eletrico
    }
    [Table("Carros")]
    public class Carro
    {
        [Key]
        public int CarroId { get; set; }

        [ForeignKey("Avalcarro")]
        public int AvalcarroId { get; set; }
        [Display(Name = "Classificação")]
        public Avalcarro Avalcarro { get; set; }

        [Required]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        //restriçoes
        [Required]
        [Display(Name = "Matricula")]
        [StringLength(6, MinimumLength = 6)]
        public string Matricula { get; set; }

        //dropdownlist
        [Required]
        [Display(Name = "Combustivél")]
        public Combustivel Gas{ get; set; }

        [Required]
        [Display(Name = "Ano")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public int Ano { get; set; }

        [Required]
        [Display(Name = "Preço diário")]
        [Column("Preço/dia")]
        public int Preçod { get; set; }

        [Required]
        [Display(Name = "Preço Mensal")]
        [Column("Preço/Mes")]
        public int Preçom { get; set; }

        public int CondAlugarId { get; set; }
        public CondAlugar CondAlugar { get; set; }

        public Carro()
        {

        }
    }
}