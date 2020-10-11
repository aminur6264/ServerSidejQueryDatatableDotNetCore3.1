using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerSidejQueryDatatableDotNetCore3._1.Migrations
{
    public partial class InvoiceIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "InvoiceDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "InvoiceDetails");
        }
    }
}
