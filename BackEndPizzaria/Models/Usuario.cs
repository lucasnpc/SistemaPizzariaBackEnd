using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Usuario
    {
        [Key]
        public string userId { get; set; }
        public string userSenha { get; set; }
        public Negocio pizzaria { get; set; }
    }
}
