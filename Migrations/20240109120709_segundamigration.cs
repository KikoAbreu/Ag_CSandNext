using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace agborala.Migrations
{
    /// <inheritdoc />
    public partial class segundamigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "id", "email", "nome", "senha" },
                values: new object[,]
                {
                    { 1, "andre@recodepro.com", "Andre", "abc123" },
                    { 2, "beatriz@recodepro.com", "Beatriz", "cde456" },
                    { 3, "carlos@recodepro.com", "Carlos", "fgh789" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
