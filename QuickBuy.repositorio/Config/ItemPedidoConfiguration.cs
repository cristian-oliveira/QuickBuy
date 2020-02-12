using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.dominio.Entidades;

namespace QuickBuy.repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(ItemPedido => ItemPedido.Id);
            builder.Property(pedido => pedido.Quantidade).IsRequired();
            //builder.Property(pedido => pedido.ProdutoId).IsRequired().HasMaxLength(50);
        }

    }
}
