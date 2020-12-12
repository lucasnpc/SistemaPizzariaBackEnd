using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BackEndPizzaria.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes_fidelizados",
                columns: table => new
                {
                    cpfCliente = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    rua = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    cidade = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes_fidelizados", x => x.cpfCliente);
                });

            migrationBuilder.CreateTable(
                name: "clientes_nao_fidelizados",
                columns: table => new
                {
                    IdCliente = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    rua = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    cidade = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes_nao_fidelizados", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "comandas",
                columns: table => new
                {
                    id_comanda = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numero_mesa = table.Column<string>(type: "text", nullable: true),
                    valor_conta = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comandas", x => x.id_comanda);
                });

            migrationBuilder.CreateTable(
                name: "contas_pagar",
                columns: table => new
                {
                    id_conta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    eh_fixa = table.Column<bool>(type: "boolean", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    data_pagamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    valor = table.Column<double>(type: "double precision", nullable: false),
                    tipo_servico = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contas_pagar", x => x.id_conta);
                });

            migrationBuilder.CreateTable(
                name: "contas_receber",
                columns: table => new
                {
                    id_conta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    valor = table.Column<double>(type: "double precision", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    data_recebimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contas_receber", x => x.id_conta);
                });

            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    cnpj = table.Column<string>(type: "text", nullable: false),
                    razao_social = table.Column<string>(type: "text", nullable: true),
                    rua = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    cidade = table.Column<string>(type: "text", nullable: true),
                    telefone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.cnpj);
                });

            migrationBuilder.CreateTable(
                name: "funcionarios",
                columns: table => new
                {
                    cpf = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    rua = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    cidade = table.Column<string>(type: "text", nullable: true),
                    telefone = table.Column<string>(type: "text", nullable: true),
                    cargo = table.Column<string>(type: "text", nullable: true),
                    data_admissão = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.cpf);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    id_pedido = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rua_entrega = table.Column<string>(type: "text", nullable: true),
                    numero_entrega = table.Column<string>(type: "text", nullable: true),
                    bairro_entrega = table.Column<string>(type: "text", nullable: true),
                    cidade_entrega = table.Column<string>(type: "text", nullable: true),
                    clienteFidelizadocpfCliente = table.Column<string>(type: "text", nullable: true),
                    valor_conta = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.id_pedido);
                    table.ForeignKey(
                        name: "FK_pedidos_clientes_fidelizados_clienteFidelizadocpfCliente",
                        column: x => x.clienteFidelizadocpfCliente,
                        principalTable: "clientes_fidelizados",
                        principalColumn: "cpfCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "notificacao_wpp",
                columns: table => new
                {
                    id_notificacao = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clienteFidelizadocpfCliente = table.Column<string>(type: "text", nullable: true),
                    clienteNaoFidelizadoIdCliente = table.Column<string>(type: "text", nullable: true),
                    pedidoid_pedido = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notificacao_wpp", x => x.id_notificacao);
                    table.ForeignKey(
                        name: "FK_notificacao_wpp_clientes_fidelizados_clienteFidelizadocpfCl~",
                        column: x => x.clienteFidelizadocpfCliente,
                        principalTable: "clientes_fidelizados",
                        principalColumn: "cpfCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_notificacao_wpp_clientes_nao_fidelizados_clienteNaoFideliza~",
                        column: x => x.clienteNaoFidelizadoIdCliente,
                        principalTable: "clientes_nao_fidelizados",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_notificacao_wpp_pedidos_pedidoid_pedido",
                        column: x => x.pedidoid_pedido,
                        principalTable: "pedidos",
                        principalColumn: "id_pedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vendas",
                columns: table => new
                {
                    id_venda = table.Column<string>(type: "text", nullable: false),
                    data_venda = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    valor_venda = table.Column<double>(type: "double precision", nullable: false),
                    tipo_venda = table.Column<string>(type: "text", nullable: true),
                    idComandaid_comanda = table.Column<int>(type: "integer", nullable: true),
                    idPedidoid_pedido = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendas", x => x.id_venda);
                    table.ForeignKey(
                        name: "FK_vendas_comandas_idComandaid_comanda",
                        column: x => x.idComandaid_comanda,
                        principalTable: "comandas",
                        principalColumn: "id_comanda",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vendas_pedidos_idPedidoid_pedido",
                        column: x => x.idPedidoid_pedido,
                        principalTable: "pedidos",
                        principalColumn: "id_pedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "itens",
                columns: table => new
                {
                    id_item = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    preco = table.Column<double>(type: "double precision", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    Comandaid_comanda = table.Column<int>(type: "integer", nullable: true),
                    Pedidoid_pedido = table.Column<int>(type: "integer", nullable: true),
                    Vendaid_venda = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itens", x => x.id_item);
                    table.ForeignKey(
                        name: "FK_itens_comandas_Comandaid_comanda",
                        column: x => x.Comandaid_comanda,
                        principalTable: "comandas",
                        principalColumn: "id_comanda",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_itens_pedidos_Pedidoid_pedido",
                        column: x => x.Pedidoid_pedido,
                        principalTable: "pedidos",
                        principalColumn: "id_pedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_itens_vendas_Vendaid_venda",
                        column: x => x.Vendaid_venda,
                        principalTable: "vendas",
                        principalColumn: "id_venda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    id_produto = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    estoque_minimo = table.Column<double>(type: "double precision", nullable: false),
                    estoque_maximo = table.Column<double>(type: "double precision", nullable: false),
                    quantidade_atual = table.Column<double>(type: "double precision", nullable: false),
                    valor_custo = table.Column<double>(type: "double precision", nullable: false),
                    id_fornecedorcnpj = table.Column<string>(type: "text", nullable: true),
                    id_item1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id_produto);
                    table.ForeignKey(
                        name: "FK_produtos_fornecedor_id_fornecedorcnpj",
                        column: x => x.id_fornecedorcnpj,
                        principalTable: "fornecedor",
                        principalColumn: "cnpj",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_produtos_itens_id_item1",
                        column: x => x.id_item1,
                        principalTable: "itens",
                        principalColumn: "id_item",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itens_Comandaid_comanda",
                table: "itens",
                column: "Comandaid_comanda");

            migrationBuilder.CreateIndex(
                name: "IX_itens_Pedidoid_pedido",
                table: "itens",
                column: "Pedidoid_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_itens_Vendaid_venda",
                table: "itens",
                column: "Vendaid_venda");

            migrationBuilder.CreateIndex(
                name: "IX_notificacao_wpp_clienteFidelizadocpfCliente",
                table: "notificacao_wpp",
                column: "clienteFidelizadocpfCliente");

            migrationBuilder.CreateIndex(
                name: "IX_notificacao_wpp_clienteNaoFidelizadoIdCliente",
                table: "notificacao_wpp",
                column: "clienteNaoFidelizadoIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_notificacao_wpp_pedidoid_pedido",
                table: "notificacao_wpp",
                column: "pedidoid_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_clienteFidelizadocpfCliente",
                table: "pedidos",
                column: "clienteFidelizadocpfCliente");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_id_fornecedorcnpj",
                table: "produtos",
                column: "id_fornecedorcnpj");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_id_item1",
                table: "produtos",
                column: "id_item1");

            migrationBuilder.CreateIndex(
                name: "IX_vendas_idComandaid_comanda",
                table: "vendas",
                column: "idComandaid_comanda");

            migrationBuilder.CreateIndex(
                name: "IX_vendas_idPedidoid_pedido",
                table: "vendas",
                column: "idPedidoid_pedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contas_pagar");

            migrationBuilder.DropTable(
                name: "contas_receber");

            migrationBuilder.DropTable(
                name: "funcionarios");

            migrationBuilder.DropTable(
                name: "notificacao_wpp");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "clientes_nao_fidelizados");

            migrationBuilder.DropTable(
                name: "fornecedor");

            migrationBuilder.DropTable(
                name: "itens");

            migrationBuilder.DropTable(
                name: "vendas");

            migrationBuilder.DropTable(
                name: "comandas");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "clientes_fidelizados");
        }
    }
}
