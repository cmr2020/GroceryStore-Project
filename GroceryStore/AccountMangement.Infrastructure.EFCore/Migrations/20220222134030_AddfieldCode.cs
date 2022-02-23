using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    public partial class AddfieldCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Accounts");
        }
    }
}
