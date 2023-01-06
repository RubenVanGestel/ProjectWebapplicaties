using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebapplicaties.Migrations
{
    public partial class ModelFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BestellingPizzaId",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PizzaGrootteId",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_BestellingPizzaId",
                table: "Pizzas",
                column: "BestellingPizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_PizzaGrootteId",
                table: "Pizzas",
                column: "PizzaGrootteId");

            migrationBuilder.CreateIndex(
                name: "IX_BestellingPizzas_BestellingId",
                table: "BestellingPizzas",
                column: "BestellingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BestellingPizzas_Bestellingen_BestellingId",
                table: "BestellingPizzas",
                column: "BestellingId",
                principalTable: "Bestellingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_BestellingPizzas_BestellingPizzaId",
                table: "Pizzas",
                column: "BestellingPizzaId",
                principalTable: "BestellingPizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_PizzaGroottes_PizzaGrootteId",
                table: "Pizzas",
                column: "PizzaGrootteId",
                principalTable: "PizzaGroottes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BestellingPizzas_Bestellingen_BestellingId",
                table: "BestellingPizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_BestellingPizzas_BestellingPizzaId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_PizzaGroottes_PizzaGrootteId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_BestellingPizzaId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_PizzaGrootteId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_BestellingPizzas_BestellingId",
                table: "BestellingPizzas");

            migrationBuilder.DropColumn(
                name: "BestellingPizzaId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "PizzaGrootteId",
                table: "Pizzas");
        }
    }
}
