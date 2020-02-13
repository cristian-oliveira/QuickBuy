using Microsoft.EntityFrameworkCore;
using QuickBuy.dominio.Entidades;
using QuickBuy.dominio.Entidades.ObjetoDeValor;
using QuickBuy.repositorio.Config;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace QuickBuy.repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public QuickBuyContexto( DbContextOptions options) : base(options)
        {


        }

        public System.Data.Entity.DbSet<Usuario> Usuarios { get; set; }
        public System.Data.Entity.DbSet<FormaPagamento> FormaPagamento { get; set; }
        public System.Data.Entity.DbSet<Pedido> Pedidos { get; set; }
        public System.Data.Entity.DbSet<Produto>  Produtos { get; set; }
        public System.Data.Entity.DbSet<ItemPedido> ItensPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<ItemPedidoConfiguration>();

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                                new FormaPagamento() { Id = 1, Nome = "Boleto", Descricao = "Forma de Pagemento por Boleto" },
                                new FormaPagamento() { Id = 2, Nome = "Cartao de Credito", Descricao = "Forma de Pagemento por Cartao de Credito" },
                                new FormaPagamento() { Id = 3, Nome = "Deposito", Descricao = "Forma de Pagemento por Deposito" });



            base.OnModelCreating(modelBuilder); // Utilizado para construir o modelo para o context
        }


    }
}

//modelBuilder.Ignore<AuditLog>();
//'EntityTypeBuilder.Ignore