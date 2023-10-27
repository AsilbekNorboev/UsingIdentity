using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Norboev_Asilbek_HW4.Migrations
{
    /// <inheritdoc />
    public partial class typeProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeProduct",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeProduct",
                table: "Products");
        }
    }
}
