using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    public partial class editcontactus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactUses_Accounts_AccountID",
                table: "ContactUses");

            migrationBuilder.DropIndex(
                name: "IX_ContactUses_AccountID",
                table: "ContactUses");

            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "ContactUses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ContactUses");

            migrationBuilder.DropColumn(
                name: "UserIp",
                table: "ContactUses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AccountID",
                table: "ContactUses",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "ContactUses",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserIp",
                table: "ContactUses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUses_AccountID",
                table: "ContactUses",
                column: "AccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUses_Accounts_AccountID",
                table: "ContactUses",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
