using System;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class ContasAPagar
    {
        [Key]
        public int idConta { get; set; }
        public bool ehFixa { get; set; }
        public string descricao { get; set; }
        public DateTime dataPagamento { get; set; }
        public double valor { get; set; }
        public string tipoServico { get; set; }
    }
}
