﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WePass.Infra.Context;

namespace WePass.Infra.Migrations
{
    [DbContext(typeof(WePassContext))]
    [Migration("20200304131329_Relacionamento_Usuario_Evento")]
    partial class Relacionamento_Usuario_Evento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WePass.Infra.Entities.Compra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<Guid>("EventoId");

                    b.Property<Guid>("PagamentoId");

                    b.Property<int>("QuantidadeIngresso");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<Guid>("UsuarioId");

                    b.HasKey("Id")
                        .HasName("Id_Compra");

                    b.HasIndex("EventoId");

                    b.HasIndex("PagamentoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("WePass.Infra.Entities.Evento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<bool>("Active");

                    b.Property<string>("Categoria");

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTime>("DataEvento");

                    b.Property<string>("NomeEvento");

                    b.Property<int>("QuantidadeIngresso");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<Guid>("UsuarioId");

                    b.Property<string>("ValorIngresso");

                    b.HasKey("Id")
                        .HasName("Id_Evento");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("WePass.Infra.Entities.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<int?>("Dinheiro");

                    b.Property<string>("FormaPagamento");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<int?>("codigoSeguranca");

                    b.Property<int?>("numeroCartao");

                    b.Property<DateTime?>("validadeCartao");

                    b.HasKey("Id")
                        .HasName("Id_Pagamento");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("WePass.Infra.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<bool>("Active");

                    b.Property<string>("Cidade");

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<int>("Idade");

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id")
                        .HasName("Id_Usuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("WePass.Infra.Entities.Compra", b =>
                {
                    b.HasOne("WePass.Infra.Entities.Evento", "Evento")
                        .WithMany("Compras")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("WePass.Infra.Entities.Pagamento", "Pagamento")
                        .WithMany("Compras")
                        .HasForeignKey("PagamentoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("WePass.Infra.Entities.Usuario", "Usuario")
                        .WithMany("Compras")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("WePass.Infra.Entities.Evento", b =>
                {
                    b.HasOne("WePass.Infra.Entities.Usuario", "Usuario")
                        .WithMany("Eventos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
