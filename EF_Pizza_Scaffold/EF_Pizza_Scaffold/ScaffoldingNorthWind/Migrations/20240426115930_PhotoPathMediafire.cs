using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScaffoldingNorthWind.Migrations
{
    /// <inheritdoc />
    public partial class PhotoPathMediafire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "Employees",
                newName: "PhotoPathMediafire");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPathMediafire",
                table: "Employees",
                newName: "PhotoPath");
        }
        //Se vuelve un alterTable Cuando se hace un update a la base de datos
    }
}
