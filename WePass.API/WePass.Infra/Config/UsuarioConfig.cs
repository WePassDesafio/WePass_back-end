using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WePass.Infra.Entities;

namespace WePass.Infra.Config
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id).HasName("Id_Usuario");
            builder.Property(x => x.Id).HasColumnName("Id");
        }
    }
}
