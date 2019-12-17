﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoRumo.Data;

namespace ProjetoRumo.Migrations
{
    [DbContext(typeof(PedidoContext))]
    partial class PedidoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoRumo.Models.Copa", b =>
                {
                    b.Property<int>("CopaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BebidaEscolhida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Quantidade")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.HasKey("CopaId");

                    b.ToTable("Copa");
                });

            modelBuilder.Entity("ProjetoRumo.Models.Cozinha", b =>
                {
                    b.Property<int>("CozinhaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PratoEscolho")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Quantidade")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.HasKey("CozinhaId");

                    b.ToTable("Cozinha");
                });

            modelBuilder.Entity("ProjetoRumo.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MesaSolicitante")
                        .IsRequired()
                        .HasColumnType("varchar(4)");

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ProjetoRumo.Models.PedidoCopa", b =>
                {
                    b.Property<int>("PedidoCopaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CopaFK")
                        .HasColumnType("int");

                    b.Property<int>("CopaId")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoFK")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.HasKey("PedidoCopaID");

                    b.HasIndex("CopaFK");

                    b.HasIndex("PedidoFK");

                    b.ToTable("PedidoCopa");
                });

            modelBuilder.Entity("ProjetoRumo.Models.PedidoCozinha", b =>
                {
                    b.Property<int>("PedidoCozinhaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CozinhaId")
                        .HasColumnType("int");

                    b.Property<int?>("CozninhaFK")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoFK")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.HasKey("PedidoCozinhaId");

                    b.HasIndex("CozninhaFK");

                    b.HasIndex("PedidoFK");

                    b.ToTable("PedidoCozinha");
                });

            modelBuilder.Entity("ProjetoRumo.Models.PedidoCopa", b =>
                {
                    b.HasOne("ProjetoRumo.Models.Copa", "Copa")
                        .WithMany("PedidosCopa")
                        .HasForeignKey("CopaFK");

                    b.HasOne("ProjetoRumo.Models.Pedido", "Pedido")
                        .WithMany("PedidoCopa")
                        .HasForeignKey("PedidoFK");
                });

            modelBuilder.Entity("ProjetoRumo.Models.PedidoCozinha", b =>
                {
                    b.HasOne("ProjetoRumo.Models.Cozinha", "Cozinha")
                        .WithMany("PedidosCozinha")
                        .HasForeignKey("CozninhaFK");

                    b.HasOne("ProjetoRumo.Models.Pedido", "Pedido")
                        .WithMany("PedidoCozinha")
                        .HasForeignKey("PedidoFK");
                });
#pragma warning restore 612, 618
        }
    }
}