using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class ho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekers_AuthUsers_AuthUserId",
                table: "JobSeekers");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthUserId",
                table: "JobSeekers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "JobSeekers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekers_AuthUsers_AuthUserId",
                table: "JobSeekers",
                column: "AuthUserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekers_AuthUsers_AuthUserId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "JobSeekers");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthUserId",
                table: "JobSeekers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekers_AuthUsers_AuthUserId",
                table: "JobSeekers",
                column: "AuthUserId",
                principalTable: "AuthUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
