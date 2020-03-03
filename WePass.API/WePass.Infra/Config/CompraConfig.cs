using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WePass.Infra.Entities;

namespace WePass.Infra.Config
{
    public class CompraConfig : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)

        {
            builder.ToTable("Compra");
            builder.HasKey(x => x.Id).HasName("Id_Compra");
            builder.Property(x => x.Id).HasColumnName("Id");
        }

    }
}
