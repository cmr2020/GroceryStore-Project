using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    public partial class AddNationalCodeinAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "Accounts");
        }
    }
}
