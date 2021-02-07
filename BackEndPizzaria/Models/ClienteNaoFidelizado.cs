using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class ClienteNaoFidelizado
    {

        [Key]
        public int IdCliente { get; set; }
        public string nome { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string telefone { get; set; }
    }
}
