using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QuickBuy.repositorio.Contexto
{
    internal class ItemPedidoConfiguration : IEntityTypeConfiguration<object>
    {
        public void Configure(EntityTypeBuilder<object> builder)
        {
        }
    }
}