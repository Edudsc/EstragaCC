using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    public class Particular
    {
        [Key]
        public int ParticularId { get; set; }

        [Display(Name = "Nome" )]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Identificação")]
        [Required]
        public int Bi { get; set; }

        [Display(Name = "Morada")]
        [Required]
        public string Morada { get; set; }
        
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Display(Name = "Carta de Condução")]
        public int Cconducao { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Telefone")]
        public int Tel { get; set; }

        //tem avaliação como cliente
        public IList<ClassifCliente> Classificacli { get; set; }
        
        //tem avaliação como fornecedor
        public IList<ClassifFornecedor> Classificaforn { get; set; }
        
        //tem um ou mais carros para alugar
        public IList<Carro> Carros { get; set; }

        //pode alugar carros
        public IList<Carro> Carroalugados { get; set; }

        //presta serviços
        public IList<Servicos> Servicoses { get; set; }

        //tem uma ou mais zonas de atuacao
        public IList<Zonas> Zonases { get; set; }

        //adicionar aqui uma lista de mensagens?

        public Particular()
        {

        }

    }//fim da classe Particular
}