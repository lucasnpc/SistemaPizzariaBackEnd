using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Fornecedor
    {
        [Key]
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string telefone { get; set; }
        public List<Produto> produtos { get; set; }
    }
}
