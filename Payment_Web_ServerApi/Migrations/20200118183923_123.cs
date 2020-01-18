using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment_Web_ServerApi.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationData",
                table: "PaymentDetails",
                newName: "ExpirationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "PaymentDetails",
                newName: "ExpirationData");
        }
    }
}
