﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PESSOAL.ControleFinanceiro.CONTEXT;

namespace PESSOAL.ControleFinanceiro.CONTEXT.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PESSOAL.ControleFinanceiro.MODELS.A_Pagar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarteiraId")
                        .HasColumnType("int");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrição")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CarteiraId");

                    b.ToTable("Contas_A_Pagar");
                });

            modelBuilder.Entity("PESSOAL.ControleFinanceiro.MODELS.Carteira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Carteiras");
                });

            modelBuilder.Entity("PESSOAL.ControleFinanceiro.MODELS.Operacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarteiraId")
                        .HasColumnType("int");

                    b.Property<int>("Cateroria")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrição")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoOperação")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CarteiraId");

                    b.ToTable("Operacoes");
                });

            modelBuilder.Entity("PESSOAL.ControleFinanceiro.MODELS.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCarteira")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("PESSOAL.ControleFinanceiro.MODELS.A_Pagar", b =>
                {
                    b.HasOne("PESSOAL.ControleFinanceiro.MODELS.Carteira", null)
                        .WithMany("ContasAPagar")
                        .HasForeignKey("CarteiraId");
                });

            modelBuilder.Entity("PESSOAL.ControleFinanceiro.MODELS.Carteira", b =>
                {
                    b.HasOne("PESSOAL.ControleFinanceiro.MODELS.Usuario", "Usuario")
                        .WithMany("Carteiras")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PESSOAL.ControleFinanceiro.MODELS.Operacao", b =>
                {
                    b.HasOne("PESSOAL.ControleFinanceiro.MODELS.Carteira", null)
                        .WithMany("Operações")
                        .HasForeignKey("CarteiraId");
                });
#pragma warning restore 612, 618
        }
    }
}