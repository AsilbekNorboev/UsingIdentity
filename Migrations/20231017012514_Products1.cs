using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Norboev_Asilbek_HW4.Migrations
{
    /// <inheritdoc />
    public partial class Products1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeProduct",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeProduct",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
