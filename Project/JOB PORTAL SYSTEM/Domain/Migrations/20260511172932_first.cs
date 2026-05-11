using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AuthUsers_AuthUserId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_AuthUserId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "AuthUserId",
                table: "Companies");

            migrationBuilder.AddColumn<Guid>(
                name: "AuthUserId",
                table: "JobProviders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobProviders_AuthUserId",
                table: "JobProviders",
                column: "AuthUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviders_AuthUsers_AuthUserId",
                table: "JobProviders",
                column: "AuthUserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProviders_AuthUsers_AuthUserId",
                table: "JobProviders");

            migrationBuilder.DropIndex(
                name: "IX_JobProviders_AuthUserId",
                table: "JobProviders");

            migrationBuilder.DropColumn(
                name: "AuthUserId",
                table: "JobProviders");

            migrationBuilder.AddColumn<Guid>(
                name: "AuthUserId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AuthUserId",
                table: "Companies",
                column: "AuthUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_AuthUsers_AuthUserId",
                table: "Companies",
                column: "AuthUserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");
        }
    }
}
