using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    public partial class AddCodeinAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NationalCode",
                table: "Accounts",
                newName: "Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Accounts",
                newName: "NationalCode");
        }
    }
}
