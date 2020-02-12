using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.dominio.Entidades;

namespace QuickBuy.repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pedido => pedido.Id);
            builder.Property(pedido => pedido.CEP).IsRequired().HasMaxLength(10);
            builder.Property(pedido => pedido.Estado).IsRequired().HasMaxLength(50);
            builder.Property(pedido => pedido.Cidade).IsRequired().HasMaxLength(50);
            builder.Property(pedido => pedido.NumeroEndereco).IsRequired().HasMaxLength(10);
            //builder.Property(pedido => pedido.FormaPagamento).IsRequired().HasMaxLength(500);
            //builder.Property(pedido => pedido.FormaPagementoId).IsRequired().HasMaxLength(500);
            builder.Property(pedido => pedido.DataPedido).IsRequired();
            //builder.Property(pedido => pedido.UsuarioId).IsRequired().HasMaxLength(500);
            builder.Property(pedido => pedido.DataPrevisaoEntrega).IsRequired();
        }
    }
}

//public int Id { get; set; }
//public DateTime DataPedido { get; set; }
//public int UsuarioId { get; set; }
//public ICollection<ItensPedido> ItensPedidos { get; set; }
//public DateTime DataPrevisaoEntrega { get; set; }
//public string CEP { get; set; }
//public string Estado { get; set; }
//public string Cidade { get; set; }
//public int NumeroEndereco { get; set; }
//public int FormaPagementoId { get; set; }
//public FormaPagamento FormaPagamento { get; set; }