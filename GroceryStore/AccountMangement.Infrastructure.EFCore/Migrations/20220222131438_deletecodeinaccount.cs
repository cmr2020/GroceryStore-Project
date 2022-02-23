using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    public partial class deletecodeinaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Accounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
