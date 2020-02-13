using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.dominio.Entidades.ObjetoDeValor;

namespace QuickBuy.repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {


        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(formaP => formaP.Id);
            builder.Property(formaP => formaP.Nome).IsRequired().HasMaxLength(50);
            builder.Property(formaP => formaP.Descricao).IsRequired().HasMaxLength(100);

        }
    }
}
