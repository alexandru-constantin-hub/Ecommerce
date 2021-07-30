using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Data.Migrations
{
    public partial class RoleAdminUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Role",
                newName: "RoleAdminName");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Role",
                newName: "RoleAdminId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoleAdminName",
                table: "Role",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "RoleAdminId",
                table: "Role",
                newName: "RoleId");
        }
    }
}
