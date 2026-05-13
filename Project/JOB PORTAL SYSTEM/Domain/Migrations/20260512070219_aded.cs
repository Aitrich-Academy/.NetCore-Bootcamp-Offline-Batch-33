using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class aded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProviders_AuthUsers_AuthUserId",
                table: "JobProviders");

            migrationBuilder.RenameColumn(
                name: "AuthUserId",
                table: "JobProviders",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobProviders_AuthUserId",
                table: "JobProviders",
                newName: "IX_JobProviders_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviders_AuthUsers_UserId",
                table: "JobProviders",
                column: "UserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProviders_AuthUsers_UserId",
                table: "JobProviders");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "JobProviders",
                newName: "AuthUserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobProviders_UserId",
                table: "JobProviders",
                newName: "IX_JobProviders_AuthUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviders_AuthUsers_AuthUserId",
                table: "JobProviders",
                column: "AuthUserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");
        }
    }
}
