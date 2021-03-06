﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrimerRegistro.DAL;

namespace PrimerRegistro.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200523062349_SegundaMigracion")]
    partial class SegundaMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("PrimerRegistro.Models.Errores", b =>
                {
                    b.Property<int>("ErrorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hallazgo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Importancia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ruta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ErrorId");

                    b.ToTable("errores");
                });
#pragma warning restore 612, 618
        }
    }
}
