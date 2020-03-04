using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WePass.Infra.Entities;

namespace WePass.Infra.Config
{
    public class EventoConfig : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("Evento");
            builder.HasKey(x => x.Id).HasName("Id_Evento");
            builder.Property(x => x.Id).HasColumnName("Id");

            builder.HasOne(u => u.Usuario).WithMany(e => e.Eventos).HasForeignKey(u => u.UsuarioId);

        }
    }
}
