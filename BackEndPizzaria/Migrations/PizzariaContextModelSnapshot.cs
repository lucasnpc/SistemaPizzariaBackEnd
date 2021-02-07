﻿// <auto-generated />
using System;
using BackEndPizzaria.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BackEndPizzaria.Migrations
{
    [DbContext(typeof(RestaurantePizzariaContext))]
    partial class PizzariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BackEndPizzaria.Models.ClienteFidelizado", b =>
                {
                    b.Property<string>("cpfCliente")
                        .HasColumnType("text");

                    b.Property<string>("bairro")
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .HasColumnType("text");

                    b.HasKey("cpfCliente");

                    b.ToTable("clientes_fidelizados");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.ClienteNaoFidelizado", b =>
                {
                    b.Property<string>("IdCliente")
                        .HasColumnType("text");

                    b.Property<string>("bairro")
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .HasColumnType("text");

                    b.HasKey("IdCliente");

                    b.ToTable("clientes_nao_fidelizados");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Comanda", b =>
                {
                    b.Property<int>("id_comanda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("numero_mesa")
                        .HasColumnType("text");

                    b.Property<double>("valor_conta")
                        .HasColumnType("double precision");

                    b.HasKey("id_comanda");

                    b.ToTable("comandas");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.ContasAPagar", b =>
                {
                    b.Property<int>("id_conta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("data_pagamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<bool>("eh_fixa")
                        .HasColumnType("boolean");

                    b.Property<string>("tipo_servico")
                        .HasColumnType("text");

                    b.Property<double>("valor")
                        .HasColumnType("double precision");

                    b.HasKey("id_conta");

                    b.ToTable("contas_pagar");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.ContasAReceber", b =>
                {
                    b.Property<int>("id_conta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("data_recebimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<double>("valor")
                        .HasColumnType("double precision");

                    b.HasKey("id_conta");

                    b.ToTable("contas_receber");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Fornecedor", b =>
                {
                    b.Property<string>("cnpj")
                        .HasColumnType("text");

                    b.Property<string>("bairro")
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.Property<string>("razao_social")
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .HasColumnType("text");

                    b.HasKey("cnpj");

                    b.ToTable("fornecedor");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Funcionario", b =>
                {
                    b.Property<string>("cpf")
                        .HasColumnType("text");

                    b.Property<string>("bairro")
                        .HasColumnType("text");

                    b.Property<string>("cargo")
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .HasColumnType("text");

                    b.Property<DateTime>("data_admissão")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .HasColumnType("text");

                    b.HasKey("cpf");

                    b.ToTable("funcionarios");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Itens", b =>
                {
                    b.Property<int>("id_item")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("Comandaid_comanda")
                        .HasColumnType("integer");

                    b.Property<int?>("Pedidoid_pedido")
                        .HasColumnType("integer");

                    b.Property<string>("Vendaid_venda")
                        .HasColumnType("text");

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<double>("preco")
                        .HasColumnType("double precision");

                    b.HasKey("id_item");

                    b.HasIndex("Comandaid_comanda");

                    b.HasIndex("Pedidoid_pedido");

                    b.HasIndex("Vendaid_venda");

                    b.ToTable("itens");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Pedido", b =>
                {
                    b.Property<int>("id_pedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("bairro_entrega")
                        .HasColumnType("text");

                    b.Property<string>("cidade_entrega")
                        .HasColumnType("text");

                    b.Property<string>("clienteFidelizadocpfCliente")
                        .HasColumnType("text");

                    b.Property<string>("numero_entrega")
                        .HasColumnType("text");

                    b.Property<string>("rua_entrega")
                        .HasColumnType("text");

                    b.Property<double>("valor_conta")
                        .HasColumnType("double precision");

                    b.HasKey("id_pedido");

                    b.HasIndex("clienteFidelizadocpfCliente");

                    b.ToTable("pedidos");
                });

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

            modelBuilder.Entity("BackEndPizzaria.Models.Produto", b =>
                {
                    b.Property<string>("id_produto")
                        .HasColumnType("text");

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<double>("estoque_maximo")
                        .HasColumnType("double precision");

                    b.Property<double>("estoque_minimo")
                        .HasColumnType("double precision");

                    b.Property<string>("id_fornecedorcnpj")
                        .HasColumnType("text");

                    b.Property<int?>("id_item1")
                        .HasColumnType("integer");

                    b.Property<double>("quantidade_atual")
                        .HasColumnType("double precision");

                    b.Property<double>("valor_custo")
                        .HasColumnType("double precision");

                    b.HasKey("id_produto");

                    b.HasIndex("id_fornecedorcnpj");

                    b.HasIndex("id_item1");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Usuario", b =>
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

            modelBuilder.Entity("BackEndPizzaria.Models.Venda", b =>
                {
                    b.Property<string>("id_venda")
                        .HasColumnType("text");

                    b.Property<DateTime>("data_venda")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("idComandaid_comanda")
                        .HasColumnType("integer");

                    b.Property<int?>("idPedidoid_pedido")
                        .HasColumnType("integer");

                    b.Property<string>("tipo_venda")
                        .HasColumnType("text");

                    b.Property<double>("valor_venda")
                        .HasColumnType("double precision");

                    b.HasKey("id_venda");

                    b.HasIndex("idComandaid_comanda");

                    b.HasIndex("idPedidoid_pedido");

                    b.ToTable("vendas");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.WhatsApp", b =>
                {
                    b.Property<int>("id_notificacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("clienteFidelizadocpfCliente")
                        .HasColumnType("text");

                    b.Property<string>("clienteNaoFidelizadoIdCliente")
                        .HasColumnType("text");

                    b.Property<int?>("pedidoid_pedido")
                        .HasColumnType("integer");

                    b.HasKey("id_notificacao");

                    b.HasIndex("clienteFidelizadocpfCliente");

                    b.HasIndex("clienteNaoFidelizadoIdCliente");

                    b.HasIndex("pedidoid_pedido");

                    b.ToTable("notificacao_wpp");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Itens", b =>
                {
                    b.HasOne("BackEndPizzaria.Models.Comanda", null)
                        .WithMany("itens")
                        .HasForeignKey("Comandaid_comanda");

                    b.HasOne("BackEndPizzaria.Models.Pedido", null)
                        .WithMany("itens")
                        .HasForeignKey("Pedidoid_pedido");

                    b.HasOne("BackEndPizzaria.Models.Venda", null)
                        .WithMany("itens_vendidos")
                        .HasForeignKey("Vendaid_venda");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Pedido", b =>
                {
                    b.HasOne("BackEndPizzaria.Models.ClienteFidelizado", "clienteFidelizado")
                        .WithMany("pedidos_cliente")
                        .HasForeignKey("clienteFidelizadocpfCliente");

                    b.Navigation("clienteFidelizado");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Produto", b =>
                {
                    b.HasOne("BackEndPizzaria.Models.Fornecedor", "id_fornecedor")
                        .WithMany("produtos")
                        .HasForeignKey("id_fornecedorcnpj");

                    b.HasOne("BackEndPizzaria.Models.Itens", "id_item")
                        .WithMany("produtos")
                        .HasForeignKey("id_item1");

                    b.Navigation("id_fornecedor");

                    b.Navigation("id_item");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Usuario", b =>
                {
                    b.HasOne("BackEndPizzaria.Models.Pizzaria", "pizzaria")
                        .WithMany("usersPizzaria")
                        .HasForeignKey("pizzariaidPizzaria");

                    b.Navigation("pizzaria");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Venda", b =>
                {
                    b.HasOne("BackEndPizzaria.Models.Comanda", "idComanda")
                        .WithMany()
                        .HasForeignKey("idComandaid_comanda");

                    b.HasOne("BackEndPizzaria.Models.Pedido", "idPedido")
                        .WithMany()
                        .HasForeignKey("idPedidoid_pedido");

                    b.Navigation("idComanda");

                    b.Navigation("idPedido");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.WhatsApp", b =>
                {
                    b.HasOne("BackEndPizzaria.Models.ClienteFidelizado", "clienteFidelizado")
                        .WithMany()
                        .HasForeignKey("clienteFidelizadocpfCliente");

                    b.HasOne("BackEndPizzaria.Models.ClienteNaoFidelizado", "clienteNaoFidelizado")
                        .WithMany()
                        .HasForeignKey("clienteNaoFidelizadoIdCliente");

                    b.HasOne("BackEndPizzaria.Models.Pedido", "pedido")
                        .WithMany()
                        .HasForeignKey("pedidoid_pedido");

                    b.Navigation("clienteFidelizado");

                    b.Navigation("clienteNaoFidelizado");

                    b.Navigation("pedido");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.ClienteFidelizado", b =>
                {
                    b.Navigation("pedidos_cliente");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Comanda", b =>
                {
                    b.Navigation("itens");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Fornecedor", b =>
                {
                    b.Navigation("produtos");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Itens", b =>
                {
                    b.Navigation("produtos");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Pedido", b =>
                {
                    b.Navigation("itens");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Pizzaria", b =>
                {
                    b.Navigation("usersPizzaria");
                });

            modelBuilder.Entity("BackEndPizzaria.Models.Venda", b =>
                {
                    b.Navigation("itens_vendidos");
                });
#pragma warning restore 612, 618
        }
    }
}
