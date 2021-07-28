using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Data.Migrations
{
    public partial class Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveryApartmentNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryCountry",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryLocality",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryProvince",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryStreet",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryStreetNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryZipCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceApartmentNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceCountry",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceLocality",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceProvince",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceStreet",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceStreetNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceZipCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDelivery",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryApartmentNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeliveryCountry",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeliveryLocality",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeliveryProvince",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeliveryStreet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeliveryStreetNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeliveryZipCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InvoiceApartmentNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InvoiceCountry",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InvoiceLocality",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InvoiceProvince",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InvoiceStreet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InvoiceStreetNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InvoiceZipCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "isDelivery",
                table: "AspNetUsers");
        }
    }
}
