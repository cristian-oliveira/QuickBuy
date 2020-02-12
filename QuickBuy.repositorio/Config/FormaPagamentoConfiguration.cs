using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.dominio.Entidades.ObjetoDeValor;

namespace QuickBuy.repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {


        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
