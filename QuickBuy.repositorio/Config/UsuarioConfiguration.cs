using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.dominio.Entidades;

namespace QuickBuy.repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(usuario => usuario.Id);
            builder.Property(usuario => usuario.Email).IsRequired().HasMaxLength(50);
            builder.Property(usuario => usuario.Nome).IsRequired().HasMaxLength(50);
            builder.Property(usuario => usuario.SobreNome).IsRequired().HasMaxLength(50);
            builder.Property(usuario => usuario.Senha).IsRequired().HasMaxLength(500);


            // Mapeamento de 1 para muitos
            builder
                .HasMany(usuario => usuario.Pedidos) // indica que usuario tem muitos pedidos
                .WithOne(pedido => pedido.Usuario); // ligado a apenas um usuario por vez    

        }

    }
}
