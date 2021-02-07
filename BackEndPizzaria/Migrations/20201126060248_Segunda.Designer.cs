﻿// <auto-generated />
using BackEndPizzaria.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BackEndPizzaria.Migrations
{
    [DbContext(typeof(RestaurantePizzariaContext))]
    [Migration("20201126060248_Segunda")]
    partial class Segunda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BackEndPizzaria.Models.Pizzaria", b =>
                {
                    b.Property<string>("idPizzaria")
                        .HasColumnType("text");

                    b.Property<string>("bairroPizzaria")
                        .HasColumnType("text");

                    b.Property<string>("cidadePizzaria")
                        .HasColumnType("text");

                    b.Property<string>("estadoPizzaria")
                        .HasColumnType("text");

                    b.Property<string>("nomePizzaria")
                        .HasColumnType("text");

                    b.Property<string>("numeroPizzaria")
                        .HasColumnType("text");

                    b.Property<string>("ruaPizzaria")
                        .HasColumnType("text");

                    b.HasKey("idPizzaria");

                    b.ToTable("pizzarias");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.UsuarioPizzaria", b =>
                {
                    b.Property<string>("userId")
                        .HasColumnType("text");

                    b.Property<string>("pizzariaidPizzaria")
                        .HasColumnType("text");

                    b.Property<string>("userSenha")
                        .HasColumnType("text");

                    b.HasKey("userId");

                    b.HasIndex("pizzariaidPizzaria");

                    b.ToTable("users");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.UsuarioPizzaria", b =>
                {
                    b.HasOne("BackEndPizzaria.Models.Pizzaria", "pizzaria")
                        .WithMany("usersPizzaria")
                        .HasForeignKey("pizzariaidPizzaria");

                    b.Navigation("pizzaria");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Pizzaria", b =>
                {
                    b.Navigation("usersPizzaria");
                });
#pragma warning restore 612, 618
        }
    }
}
