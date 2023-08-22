using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exo1.Migrations
{
    public partial class UpdateStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Addresses",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Addresses",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Complement",
                table: "Addresses",
                newName: "complement");

            migrationBuilder.RenameColumn(
                name: "Commune",
                table: "Addresses",
                newName: "commune");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Addresses",
                newName: "postal_code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Addresses",
                newName: "address_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "number",
                table: "Addresses",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Addresses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "complement",
                table: "Addresses",
                newName: "Complement");

            migrationBuilder.RenameColumn(
                name: "commune",
                table: "Addresses",
                newName: "Commune");

            migrationBuilder.RenameColumn(
                name: "postal_code",
                table: "Addresses",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "Addresses",
                newName: "Id");
        }
    }
}
