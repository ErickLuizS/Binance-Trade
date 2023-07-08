using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrandingBotClasses.Migrations.SqlServer
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    ContaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    apiKey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    apiSecret = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.ContaId);
                });

            migrationBuilder.CreateTable(
                name: "Planilhas",
                columns: table => new
                {
                    PlanilhaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SheetID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TabName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planilhas", x => x.PlanilhaId);
                });

            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    TradeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    orderId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quoteQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    comission = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    comissionAsset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContaCBinanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.TradeId);
                    table.ForeignKey(
                        name: "FK_Trades_Contas_ContaCBinanceId",
                        column: x => x.ContaCBinanceId,
                        principalTable: "Contas",
                        principalColumn: "ContaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    CBinanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoogleSheetsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_Contas_CBinanceId",
                        column: x => x.CBinanceId,
                        principalTable: "Contas",
                        principalColumn: "ContaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Planilhas_GoogleSheetsId",
                        column: x => x.GoogleSheetsId,
                        principalTable: "Planilhas",
                        principalColumn: "PlanilhaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CBinanceId",
                table: "Clientes",
                column: "CBinanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_GoogleSheetsId",
                table: "Clientes",
                column: "GoogleSheetsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trades_ContaCBinanceId",
                table: "Trades",
                column: "ContaCBinanceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Trades");

            migrationBuilder.DropTable(
                name: "Planilhas");

            migrationBuilder.DropTable(
                name: "Contas");
        }
    }
}
