using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Data.Migrations
{
    public partial class SmallchangeinAddresscs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDelivery",
                table: "AspNetUsers",
                newName: "IsDelivery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDelivery",
                table: "AspNetUsers",
                newName: "isDelivery");
        }
    }
}
