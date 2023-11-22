using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaBay.Migrations
{
    /// <inheritdoc />
    public partial class addedPizzaOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaOrderModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasePrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaOrderModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaOrderModels");
        }
    }
}
