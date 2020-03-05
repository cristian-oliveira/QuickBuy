using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.dominio.Entidades;

namespace QuickBuy.repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(produto => produto.Id);
            builder.Property(produto => produto.Nome).IsRequired().HasMaxLength(50);
            builder.Property(produto => produto.Preco).HasColumnType("decimal").IsRequired().HasMaxLength(13);
            builder.Property(produto => produto.Descricao).IsRequired().HasMaxLength(500);
            //builder.Property(usuario => usuario.Pedidos).IsRequired().HasMaxLength(500);

        }
    }
}
