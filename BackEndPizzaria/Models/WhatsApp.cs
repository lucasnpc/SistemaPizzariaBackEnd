using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class WhatsApp
    {
        [Key]
        public int id_notificacao { get; set; }
        public ClienteFidelizado clienteFidelizado { get; set; }
        public ClienteNaoFidelizado clienteNaoFidelizado { get; set; }
        public Pedido pedido { get; set; }
    }
}
