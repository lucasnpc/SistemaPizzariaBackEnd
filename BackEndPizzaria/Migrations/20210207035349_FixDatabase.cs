using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BackEndPizzaria.Migrations
{
    public partial class FixDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientesFidelizados",
                columns: table => new
                {
                    cpfCliente = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    rua = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    cidade = table.Column<string>(type: "text", nullable: true),
                    telefone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientesFidelizados", x => x.cpfCliente);
                });

            migrationBuilder.CreateTable(
                name: "clientesNaoFidelizados",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    rua = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    cidade = table.Column<string>(type: "text", nullable: true),
                    telefone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientesNaoFidelizados", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "comandas",
                columns: table => new
                {
                    idComanda = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numeroMesa = table.Column<string>(type: "text", nullable: true),
                    valorConta = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comandas", x => x.idComanda);
                });

            migrationBuilder.CreateTable(
                name: "contasPagar",
                columns: table => new
                {
                    idConta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ehFixa = table.Column<bool>(type: "boolean", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    dataPagamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    valor = table.Column<double>(type: "double precision", nullable: false),
                    tipoServico = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contasPagar", x => x.idConta);
                });

            migrationBuilder.CreateTable(
                name: "contasReceber",
                columns: table => new
                {
                    idConta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    valor = table.Column<double>(type: "double precision", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    dataRecebido = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contasReceber", x => x.idConta);
                });

            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    cnpj = table.Column<string>(type: "text", nullable: false),
                    razaoSocial = table.Column<string>(type: "text", nullable: true),
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
                    dataAdmissao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.cpf);
                });

            migrationBuilder.CreateTable(
                name: "negocios",
                columns: table => new
                {
                    idNegocio = table.Column<string>(type: "text", nullable: false),
                    nomeNegocio = table.Column<string>(type: "text", nullable: true),
                    ruaNegocio = table.Column<string>(type: "text", nullable: true),
                    numeroNegocio = table.Column<string>(type: "text", nullable: true),
                    bairroNegocio = table.Column<string>(type: "text", nullable: true),
                    cidadeNegocio = table.Column<string>(type: "text", nullable: true),
                    estadoNegocio = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_negocios", x => x.idNegocio);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    idPedido = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ruaEntrega = table.Column<string>(type: "text", nullable: true),
                    numeroEntrega = table.Column<string>(type: "text", nullable: true),
                    bairroEntrega = table.Column<string>(type: "text", nullable: true),
                    cidadeEntrega = table.Column<string>(type: "text", nullable: true),
                    clienteFidelizadocpfCliente = table.Column<string>(type: "text", nullable: true),
                    valorConta = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.idPedido);
                    table.ForeignKey(
                        name: "FK_pedidos_clientesFidelizados_clienteFidelizadocpfCliente",
                        column: x => x.clienteFidelizadocpfCliente,
                        principalTable: "clientesFidelizados",
                        principalColumn: "cpfCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<string>(type: "text", nullable: false),
                    userSenha = table.Column<string>(type: "text", nullable: true),
                    pizzariaidNegocio = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_users_negocios_pizzariaidNegocio",
                        column: x => x.pizzariaidNegocio,
                        principalTable: "negocios",
                        principalColumn: "idNegocio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "itensCardapio",
                columns: table => new
                {
                    id_item = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    preco = table.Column<double>(type: "double precision", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    ComandaidComanda = table.Column<int>(type: "integer", nullable: true),
                    PedidoidPedido = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itensCardapio", x => x.id_item);
                    table.ForeignKey(
                        name: "FK_itensCardapio_comandas_ComandaidComanda",
                        column: x => x.ComandaidComanda,
                        principalTable: "comandas",
                        principalColumn: "idComanda",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_itensCardapio_pedidos_PedidoidPedido",
                        column: x => x.PedidoidPedido,
                        principalTable: "pedidos",
                        principalColumn: "idPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vendas",
                columns: table => new
                {
                    idVenda = table.Column<string>(type: "text", nullable: false),
                    dataVenda = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    valorVenda = table.Column<double>(type: "double precision", nullable: false),
                    tipoVenda = table.Column<string>(type: "text", nullable: true),
                    idComanda1 = table.Column<int>(type: "integer", nullable: true),
                    idPedido1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendas", x => x.idVenda);
                    table.ForeignKey(
                        name: "FK_vendas_comandas_idComanda1",
                        column: x => x.idComanda1,
                        principalTable: "comandas",
                        principalColumn: "idComanda",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vendas_pedidos_idPedido1",
                        column: x => x.idPedido1,
                        principalTable: "pedidos",
                        principalColumn: "idPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    idProduto = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    estoqueMinimo = table.Column<double>(type: "double precision", nullable: false),
                    estoqueMaximo = table.Column<double>(type: "double precision", nullable: false),
                    quantidadeAtual = table.Column<double>(type: "double precision", nullable: false),
                    valorCusto = table.Column<double>(type: "double precision", nullable: false),
                    idFornecedorcnpj = table.Column<string>(type: "text", nullable: true),
                    idItemid_item = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.idProduto);
                    table.ForeignKey(
                        name: "FK_produtos_fornecedor_idFornecedorcnpj",
                        column: x => x.idFornecedorcnpj,
                        principalTable: "fornecedor",
                        principalColumn: "cnpj",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_produtos_itensCardapio_idItemid_item",
                        column: x => x.idItemid_item,
                        principalTable: "itensCardapio",
                        principalColumn: "id_item",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itensCardapio_ComandaidComanda",
                table: "itensCardapio",
                column: "ComandaidComanda");

            migrationBuilder.CreateIndex(
                name: "IX_itensCardapio_PedidoidPedido",
                table: "itensCardapio",
                column: "PedidoidPedido");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_clienteFidelizadocpfCliente",
                table: "pedidos",
                column: "clienteFidelizadocpfCliente");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_idFornecedorcnpj",
                table: "produtos",
                column: "idFornecedorcnpj");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_idItemid_item",
                table: "produtos",
                column: "idItemid_item");

            migrationBuilder.CreateIndex(
                name: "IX_users_pizzariaidNegocio",
                table: "users",
                column: "pizzariaidNegocio");

            migrationBuilder.CreateIndex(
                name: "IX_vendas_idComanda1",
                table: "vendas",
                column: "idComanda1");

            migrationBuilder.CreateIndex(
                name: "IX_vendas_idPedido1",
                table: "vendas",
                column: "idPedido1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientesNaoFidelizados");

            migrationBuilder.DropTable(
                name: "contasPagar");

            migrationBuilder.DropTable(
                name: "contasReceber");

            migrationBuilder.DropTable(
                name: "funcionarios");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "vendas");

            migrationBuilder.DropTable(
                name: "fornecedor");

            migrationBuilder.DropTable(
                name: "itensCardapio");

            migrationBuilder.DropTable(
                name: "negocios");

            migrationBuilder.DropTable(
                name: "comandas");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "clientesFidelizados");
        }
    }
}
