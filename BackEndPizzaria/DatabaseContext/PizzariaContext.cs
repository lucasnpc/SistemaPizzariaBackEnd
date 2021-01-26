using BackEndPizzaria.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndPizzaria.Context
{
    public class PizzariaContext : DbContext
    {
        public PizzariaContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ClienteFidelizado> clientesFidelizados { get; set; }
        public DbSet<ClienteNaoFidelizado> clientesNaoFidelizados { get; set; }
        public DbSet<Comanda> comandas { get; set; }
        public DbSet<ContasAPagar> contasPagar { get; set; }
        public DbSet<ContasAReceber> contasReceber { get; set; }
        public DbSet<Fornecedor> fornecedor { get; set; }
        public DbSet<Funcionario> funcionarios { get; set; }
        public DbSet<Itens> itens { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
        public DbSet<Negocio> pizzarias { get; set; }
        public DbSet<Produto> produtos { get; set; }
        public DbSet<Usuario> users { get; set; }
        public DbSet<Venda> vendas { get; set; }
        public DbSet<WhatsApp> notificacaoWpp { get; set; }
    }
}
