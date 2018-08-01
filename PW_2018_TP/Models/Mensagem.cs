using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TP.Models;

namespace PW_2018_TP.Models
{
    [Table("Mensagens")]
    public class Mensagem
    {
        [Key]
        public int MensagemId { get; set; }

        public int RemetenteId { get; set; }

        public int DestinatarioId { get; set; }

        [Display(Name = "Mensagem")]
        public string Data { get; set; }

        public bool Lida { get; set; }

        public Mensagem()
        {

        }

    }
}