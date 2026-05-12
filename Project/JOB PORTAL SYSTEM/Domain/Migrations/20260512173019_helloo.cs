using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class helloo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AuthUsers_UserId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Companies",
                newName: "AuthUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_UserId",
                table: "Companies",
                newName: "IX_Companies_AuthUserId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_AuthUsers_AuthUserId",
                table: "Companies",
                column: "AuthUserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AuthUsers_AuthUserId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "AuthUserId",
                table: "Companies",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_AuthUserId",
                table: "Companies",
                newName: "IX_Companies_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_AuthUsers_UserId",
                table: "Companies",
                column: "UserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");
        }
    }
}
