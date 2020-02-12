using Microsoft.EntityFrameworkCore;
using QuickBuy.dominio.Entidades;
using QuickBuy.dominio.Entidades.ObjetoDeValor;
using QuickBuy.repositorio.Config;

namespace QuickBuy.repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public QuickBuyContexto( DbContextOptions options) : base(options)
        {


        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<dominio.Entidades.ObjetoDeValor.FormaPagamento>  FormaPagamento { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto>  Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            base.OnModelCreating(modelBuilder); // Utilizado para construir o modelo para o context
        }


    }
}
