using System;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class ContasAReceber
    {
        [Key]
        public int id_conta { get; set; }
        public double valor { get; set; }
        public string descricao { get; set; }
        public DateTime data_recebimento { get; set; }
    }
}
