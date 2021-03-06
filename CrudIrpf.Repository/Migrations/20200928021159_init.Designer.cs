﻿// <auto-generated />
using System;
using CrudIrpf.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudIrpf.Repository.Migrations
{
    [DbContext(typeof(CrudIrpfContext))]
    [Migration("20200928021159_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("CrudIrpf.Domain.Irpf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("CpfCnpj")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<double>("RendimentosTributaveis")
                        .HasColumnType("REAL");

                    b.Property<string>("TituloEleitoral")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Irpfs");
                });
#pragma warning restore 612, 618
        }
    }
}
