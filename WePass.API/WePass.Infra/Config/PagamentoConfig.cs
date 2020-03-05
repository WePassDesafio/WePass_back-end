using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WePass.Infra.Entities;

namespace WePass.Infra.Config
{
    public class PagamentoConfig : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento");
            builder.HasKey(x => x.Id).HasName("Id_Pagamento");
            builder.Property(x => x.Id).HasColumnName("Id");

            builder.HasOne(u => u.Usuario).WithMany(p => p.Pagamentos).HasForeignKey(a => a.UsuarioId);
        }
    }
}
