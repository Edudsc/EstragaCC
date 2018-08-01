using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("Profissionais")]
    public class Profissional
    {
        [Key]
        public int ProfissionalId { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Denominação Social")]
        [Required]
        public int Social { get; set; }

        [Display(Name = "Morada")]
        [Required]
        public string Morada { get; set; }

        [Display(Name = "Data de Fundacao")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        
        [Display(Name = "Telefone")]
        [Phone]
        public int Tel { get; set; }

        //tem avaliação como fornecedor
        public IList<ClassifFornecedor> Classificaforn { get; set; }

        //tem um ou mais carros para alugar
        public IList<Carro> Carros { get; set; }

        //presta serviços
        public IList<Servicos> Servicoses { get; set; }

        //Lista de mensagens?
        public IList<Mensagem> Mensagens { get; set; }

        public Profissional()
        {

        }
    }
}