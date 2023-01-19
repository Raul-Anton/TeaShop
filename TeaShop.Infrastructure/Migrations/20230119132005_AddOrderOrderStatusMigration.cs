using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeaShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderOrderStatusMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "orderStatus",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "orderStatus",
                table: "Orders");
        }
    }
}
