using System;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Funcionario
    {
        [Key]
        public string cpf { get; set; }
        public string nome { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string telefone { get; set; }
        public string cargo { get; set; }
        public DateTime data_admissão { get; set; }

    }
}
