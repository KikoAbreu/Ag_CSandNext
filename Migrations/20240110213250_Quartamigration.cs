using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace agborala.Migrations
{
    /// <inheritdoc />
    public partial class Quartamigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgurl",
                table: "destino",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "destino",
                keyColumn: "id",
                keyValue: 1,
                column: "imgurl",
                value: "https://pixabay.com/pt/photos/fernando-de-noronha-mar-ilha-2581811/");

            migrationBuilder.UpdateData(
                table: "destino",
                keyColumn: "id",
                keyValue: 2,
                column: "imgurl",
                value: "https://pixabay.com/pt/photos/igreja-pedra-constru%C3%A7%C3%A3o-medieval-5837123/");

            migrationBuilder.UpdateData(
                table: "destino",
                keyColumn: "id",
                keyValue: 3,
                column: "imgurl",
                value: "https://pixabay.com/pt/photos/p%C3%A3o-de-a%C3%A7%C3%BAcar-bonde-bondinho-1679285/");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgurl",
                table: "destino");
        }
    }
}
